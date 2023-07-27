using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotspots.data.Entities;
using Hotspots.models.UserVM;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace Hotspots.services.UserServices
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private string USERNAME = "";

        public AuthenticationManager(IConfiguration configuration, IMapper mapper, UserManager<User> userManager)
        {
            _configuration = configuration;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<AuthResponseVM> Login(LoginVM loginVM)
        {
            var user = await _userManager.FindByEmailAsync(loginVM.Email);
            bool isValidUser = await _userManager.CheckPasswordAsync(user!, loginVM.Password);
            if(user is null || isValidUser == false)
            {
                return new AuthResponseVM();
            }
            var token = await GenerateToken(user);

        return new AuthResponseVM
        {
            UserName = USERNAME, 
            Token = token
        };

        }

        public Task<IEnumerable<IdentityError>> Reguster(UserEntityVM userEntity)
        {
            throw new NotImplementedException();
        }

        private async Task<string> GenerateToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var roles = await _userManager.GetRolesAsync(user);
            var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();
            var userClaims = await _userManager.GetClaimsAsync(user);
            var claims = new List<Claim>
            {
                new Claim("name", $"{user.FullName}"),
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uId", user.Id)
        }

        .Union(userClaims)
        .Union(roleClaims);

        USERNAME = claims.FirstOrDefault(x => x.Type == "name")?.Value;

        var token = new JwtSecurityToken(
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Audience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(30),
            signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);

        public static async Task<IEnumerable<IdentityError>> Register(UserEntityVM userEntity)
        {
            var user = @this._mapper.Map<User>(userEntity);
            user.UserName = userEntity.Email;
            var result = await @this._userManager.CreateAsync(user, userEntity.Password);
            if (result.Succeeded)
            {
                await @this._userManager.AddToRoleAsync(user, "User");
            }
            return result.Errors;
        }
    }
}
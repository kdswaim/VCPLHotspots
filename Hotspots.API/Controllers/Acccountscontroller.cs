using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Hotspots.models.UserVM;
using Hotspots.services.UserServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hotspots.API.Controllers
{
    [Route("[controller]")]
    public class Acccountscontroller : Controller
    {
        private readonly IAuthenticationManager _authManager;
        public Acccountscontroller(IAuthenticationManager authManager)
        {
            _authManager = authManager;
        }
        [HttpPost]
        [Route("register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Register([FromBody] UserEntityVM userEntity)
        {
            var errors = await _authManager.Reguster(userEntity);
            if (errors.Any())
            {
                foreach (var identityErrorerror in errors)
                {
                    ModelState.AddModelError("", identityErrorerror.Description);
                }
            }
            return Ok("User Registered Successfully");
        }
        [HttpPost]
        [Route("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Login([FromBody] LoginVM loginVM)
        {
            var result = await _authManager.Login(loginVM);
            if (result is null)
            {
                return BadRequest("Invalid Request");
            }
            return Ok(result);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotspots.models.UserVM;
using Microsoft.AspNetCore.Identity;

namespace Hotspots.services.UserServices
{
    public interface IAuthenticationManager
    {
        Task<IEnumerable<IdentityError>>Reguster(UserEntityVM userEntity);
        Task<AuthResponseVM> Login(LoginVM loginVM);
        
    }
}
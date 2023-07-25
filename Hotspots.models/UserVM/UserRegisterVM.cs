using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotspots.models.UserVM
{
    public class UserRegisterVM
    {
        [Required]
        public string Email {get; set;} = null!;
        [Required]
        [MinLength(4)]
        public string UserName {get; set;} = null!;
        [Required]
        [MinLength(4)]
        public string Password {get; set;} = null!;
        [Compare(nameof(Password))]
        public string ConfirmPassword {get; set;} = null!;
    }
}
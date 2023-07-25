using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotspots.models.UserVM
{
    public class LoginVM
    {
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        [Required]
        [StringLength(15, ErrorMessage = "The password has a limit of {2} to {1} characters", MinimumLength =6)]
        public string Password {get; set;}
    }
}
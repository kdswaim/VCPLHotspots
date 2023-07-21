using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Hotspots.data.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName {get; set;} = string.Empty;

        public string FullName {get { return $"{FirstName} {LastName}";}}
        [Required]
        public string Username {get; set;}
        [Required]
        public string Password {get; set;}

        [Required]
        public string Role {get; set;}

    }
}
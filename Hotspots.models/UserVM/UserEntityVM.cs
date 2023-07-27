using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotspots.models.UserVM
{
    public class UserEntityVM : LoginVM
    {
        [Required]
        public string FirstName {get; set;} = null!;
        [Required]
        public string LastName {get; set;} = null!;
    }
}
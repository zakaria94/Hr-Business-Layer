using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.BL.Models
{
    public class SignUpVM
    {
        [Required(ErrorMessage = "UserName Required")]
        public string UserName { get; set; }

        //[Required(ErrorMessage = "FirstName Required")]
        //public string FirstName { get; set; }

        //[Required(ErrorMessage = "LastName Required")]
        //public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "InValid Email")]
        [Required(ErrorMessage ="Required!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required!")]
        [MinLength(6,ErrorMessage ="Min Len 6")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Required!")]
        [MinLength(6, ErrorMessage = "Min Len 6")]
        [Compare("Password", ErrorMessage ="Password Not Match")]
        public string ConfirmPassword { get; set; }

        public bool IsAgree { get; set; }
    }
}

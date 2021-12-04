using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.BL.Models
{
    public class LogInVM
    {
        [EmailAddress(ErrorMessage = "InValid Email")]
        [Required(ErrorMessage = "Required!")]
        public string Email { get; set; }

        [Required(ErrorMessage = " Password Required!")]
        [MinLength(6, ErrorMessage = "Min Len 6")]
        public string Password { get; set; }

        public bool RemeberMe { get; set; }
    }
}

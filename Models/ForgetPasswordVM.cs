using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.BL.Models
{
    public class ForgetPasswordVM
    {
        [EmailAddress(ErrorMessage = "InValid Email")]
        [Required(ErrorMessage = "Required!")]
        public string Email { get; set; }
    }
}

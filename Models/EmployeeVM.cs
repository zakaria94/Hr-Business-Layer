using System.ComponentModel.DataAnnotations;
using Tamplate.DAL.Enitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Template.BL.Models
{
    public class EmployeeVM
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="Name Required")]
        [MinLength(2,ErrorMessage = "Min Length 2")]
        [MaxLength(50,ErrorMessage = "Max Length 50")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Salary Required")]
        [Range(2000,15000,ErrorMessage ="Enter Salary between 2K and 3K")]
        public float Salary { get; set; }

        public DateTime HireDate { get; set; }

        public bool IsActive { get; set; }

        public string Notes { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="!Choose Dipertment")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        
        [Required(ErrorMessage ="! Choose District")]
        public int DistrictId { get; set; }
        public District District { get; set; }

        public string CvUrl { get; set; }

        public string ImageUrl { get; set; }

        public IFormFile Cv { get; set; }

        public IFormFile Image { get; set; }

    }
}

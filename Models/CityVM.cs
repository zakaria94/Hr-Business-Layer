using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamplate.DAL.Enitity;

namespace Template.BL.Models
{
    public class CityVM
    {
        public int Id { get; set; }

       
        public string Name { get; set; }

        public int CountryId { get; set; }

       
        public Country Country { get; set; }

        public ICollection<District> District { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamplate.DAL.Enitity;

namespace Template.BL.Models
{
    public class CountryVM
    {
        public int Id { get; set; }

        
        public string Name { get; set; }

        public ICollection<City> City { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.BL.Helper
{
    public class ApiResponce<Type>
    {
        public string code { get; set; }
        public string status { get; set; }
        public string message { get; set; }
        public Type data { get; set; }  // success
        public Type error { get; set; } // Faild
    }
}

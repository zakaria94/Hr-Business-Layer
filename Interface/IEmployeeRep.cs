using Template.BL.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tamplate.DAL.Enitity;

namespace Template.BL.Interface
{
    public interface IEmployeeRep
    {
        //IQueryable<EmployeeVM> Get();
        //EmployeeVM GetById(int id);
        //void Create(EmployeeVM emp);
        //void Update(EmployeeVM emp);
        //void Delete(EmployeeVM Emp);

        IEnumerable<Employee> SearchBYName(string name);
    }
}

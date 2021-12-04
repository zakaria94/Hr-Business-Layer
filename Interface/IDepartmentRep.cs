using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamplate.DAL.Enitity;
using Template.BL.Models;

namespace Template.BL.Interface
{
    public interface IDepartmentRep
    {
        //IQueryable<DepartmentVM> Get();
        //DepartmentVM GetById(int id);
        //void Create(DepartmentVM dept);
        //void Update(DepartmentVM dept);
        //void Delete(DepartmentVM dept);

        IEnumerable<Department> SearchBYName(string name);
    }
}

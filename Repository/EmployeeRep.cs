using Microsoft.EntityFrameworkCore;
using Tamplate.DAL.Database;
using Tamplate.DAL.Enitity;
using Template.BL.Interface;
using System.Linq;
using System.Collections.Generic;
using AutoMapper;
using Template.BL.Models;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Template.BL.Repository
{
    public class EmployeeRep : IEmployeeRep
    {
        private readonly TemplateContext db;
        private readonly IMapper mapper;

        public EmployeeRep(TemplateContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public IEnumerable<Employee> SearchBYName(string Name)
        {
            var data = db.Employee.Include("Department").Include("District").Where(a => a.Name.Contains(Name));

            return data;
        }

        //public IQueryable<EmployeeVM> Get()
        //{
        //    var data = GetEmployees();
        //    return data;
        //}

        //public EmployeeVM GetById(int id)
        //{
        //    EmployeeVM data = GetEmpById(id);

        //    return data;
        //}

        //public void Create(EmployeeVM Emp)
        //{
        //    var data = mapper.Map<Employee>(Emp);

        //    db.Employee.Add(data);
        //    db.SaveChanges();
        //}

        //public void Update(EmployeeVM Emp)
        //{
        //    var data = mapper.Map<Employee>(Emp);

        //    db.Entry(data).State = EntityState.Modified;
        //    db.SaveChanges();
        //}

        //public void Delete(EmployeeVM Emp)
        //{
        //    var data = mapper.Map<Employee>(Emp);

        //    db.Entry(data).State = EntityState.Deleted;
        //    db.SaveChanges();

        //}

        //// ============Refactor=========================

        //private IQueryable<EmployeeVM> GetEmployees()
        //{
        //    return db.Employee.Select(a => new EmployeeVM
        //    {
        //         Id = a.Id,
        //         IsActive = a.IsActive,
        //         DepartmentId = a.DepartmentId,
        //         Email = a.Email,
        //         HireDate = a.HireDate,
        //         Name = a.Name,
        //         Notes = a.Notes,
        //         Salary = a.Salary,
        //        // DepartmentName = a.Department.DepartmentName
        //    });
        //}

        //private EmployeeVM GetEmpById(int id)
        //{
        //    return db.Employee.Where(a => a.Id == id)
        //         .Select(a => new EmployeeVM
        //         {
        //             Id = a.Id,
        //             IsActive = a.IsActive,
        //             DepartmentId = a.DepartmentId,
        //             Email = a.Email,
        //             HireDate = a.HireDate,
        //             Name = a.Name,
        //             Notes = a.Notes,
        //             Salary = a.Salary,
        //             //DepartmentName = a.Department.DepartmentName
        //         }).FirstOrDefault();
        //} 
    }
}

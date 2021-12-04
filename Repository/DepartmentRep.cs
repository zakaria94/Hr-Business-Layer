using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamplate.DAL.Database;
using Tamplate.DAL.Enitity;
using Template.BL.Interface;
using Template.BL.Models;

namespace Template.BL.Repository
{
    public class DepartmentRep : IDepartmentRep
    {
        private readonly TemplateContext db;
        private readonly IMapper mapper;

        public DepartmentRep(TemplateContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public IEnumerable<Department> SearchBYName(string Name)
        {
            var data = db.Department.Where(a => a.DepartmentName.Contains(Name));

            return data;
        }

        //public IQueryable<DepartmentVM> Get()
        //{
        //    var data = GetDepartments();
        //    return data;
        //}


        //public DepartmentVM GetById(int id)
        //{
        //    var data = db.Department.Where(a => a.Id == id)
        //         .Select(a => new DepartmentVM
        //         {
        //             Id = a.Id,
        //             DepartmentName = a.DepartmentName,
        //             DepartmentCode = a.DepartmentCode
        //         }).FirstOrDefault();

        //    return data;
        //}

        //public void Create(DepartmentVM dept)
        //{
        //    var data = mapper.Map<Department>(dept);

        //    db.Department.Add(data);
        //    db.SaveChanges();
        //}

        //public void Update(DepartmentVM dept)
        //{
        //    var data = mapper.Map<Department>(dept);

        //    db.Entry(data).State = EntityState.Modified;
        //    db.SaveChanges();
        //}

        //public void Delete(DepartmentVM dept)
        //{
        //    //var oldData = db.Department.Find(id);

        //    //db.Department.Remove(oldData);
        //    var data = mapper.Map<Department>(dept);

        //    db.Entry(data).State = EntityState.Deleted;
        //    db.SaveChanges();

        //}


        // ============Refactor=========================

        //private IQueryable<DepartmentVM> GetDepartments()
        //{
        //    return db.Department.Select(a => new DepartmentVM
        //    {
        //        Id = a.Id,
        //        DepartmentName = a.DepartmentName,
        //        DepartmentCode = a.DepartmentCode
        //    });
        //}
    }
}

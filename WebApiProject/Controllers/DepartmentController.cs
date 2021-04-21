using System;
using System.Collections.Generic;
using PetaPoco;
using Microsoft.AspNetCore.Mvc;
using Contracts;
using Models;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("api/department")]
    public class DepartmentController : Controller
    {
        public IDepartmentService _departmentService { get; set; }

        public DepartmentController(IDepartmentService departmentService)
        {
            this._departmentService = departmentService;
        }

        [HttpGet]
        [Route("alldepartmentdetails")]
        public IList<Department> GetDepartments()
        {
            return _departmentService.GetAllDepartments();
        }

        [HttpPost]
        [Route("create")]
        public void AddDepartment(Department department)
        {
            this._departmentService.AddDepartment(department);
        }

        [HttpPut]
        [Route("update")]
        public void UpdateDepartment(Department department)
        {
            this._departmentService.UpdateDepartment(department);
        }

        [HttpDelete]
        public void DeleteDepartment(int id)
        {
            this._departmentService.DeleteDepartment(id);
        }
    }
}
using System;
using System.Collections.Generic;
using PetaPoco;
using Microsoft.AspNetCore.Mvc;
using Contracts;
using Models;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("api/employee")]
    public class EmployeeController : Controller
    {
        public IEmployeeService _employeeService { get; set; }

        public EmployeeController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        [HttpGet]
        [Route("allemployeedetails")]
        public IList<Employee> GetEmployees()
        {
            return this._employeeService.GetAllEmployees();
        }

        [HttpGet]
        [Route("getsingleemployee")]
        public IList<Employee> GetId()
        {
            return this._employeeService.GetCurrentId();
        }


        [HttpPost]
        [Route("insertemployeedetails")]
        public void InsertEmployee(Employee employee)
        {
            this._employeeService.InsertEmployee(employee);
        }

        [HttpPut]
        [Route("updateemployeedetails")]
        public void UpdateEmployee(Employee employee)
        {
            this._employeeService.UpdateEmployee(employee);
        }

        [HttpDelete]
        public void DeleteEmployee(int id)
        {
            this._employeeService.DeleteEmployee(id);
        }

    }
}
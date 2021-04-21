using System;
using System.Collections.Generic;
using PetaPoco;
using Contracts;
using Models;
namespace Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly PetaPoco.Database connection;
        public EmployeeService(PetaPoco.Database database)
        {
            this.connection = database;
        }

        public IList<Employee> GetAllEmployees()
        {
            string query = "SELECT * FROM Employee";
            IList<Employee> employeeList = this.connection.Fetch<Employee>(query);

            return employeeList;
        }

        public void InsertEmployee(Employee employee)
        {

            this.connection.Insert("Employee", "id", false, employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            this.connection.Update("Employee", "id", employee);
        }

        public void DeleteEmployee(int id)
        {
            this.connection.Delete<Employee>(id);
        }

        public IList<Employee> GetCurrentId()
        {
            string query = "SELECT TOP 1 id  FROM EMPLOYEE ORDER BY id DESC";
            IList<Employee> employeeList = this.connection.Fetch<Employee>(query);
            return employeeList;
        }
    }

}

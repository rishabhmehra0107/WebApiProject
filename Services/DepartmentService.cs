using System;
using System.Collections.Generic;
using PetaPoco;
using Contracts;
using Models;

namespace Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly PetaPoco.Database connection;
        public DepartmentService(PetaPoco.Database database)
        {
            this.connection = database;
        }

        public IList<Department> GetAllDepartments()
        {
            string query = "SELECT * FROM Department";
            IList<Department> departmentList = this.connection.Fetch<Department>(query);

            return departmentList;
        }

        public void AddDepartment(Department department)
        {

            this.connection.Insert("Department", "Id", true, department);
        }

        public void UpdateDepartment(Department department)
        {
            this.connection.Update("Department", "Id", department);
        }

        public void DeleteDepartment(int id)
        {
            this.connection.Delete<Department>(id);
        }
    }

}

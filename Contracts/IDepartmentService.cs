using System;
using System.Collections.Generic;
using Models;

namespace Contracts
{
    public interface IDepartmentService
    {
        IList<Department> GetAllDepartments();
        void AddDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(int id);
    }
}

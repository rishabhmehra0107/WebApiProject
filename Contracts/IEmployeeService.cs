using System.Collections.Generic;
using Models;
namespace Contracts
{
    public interface IEmployeeService
    {
        IList<Employee> GetAllEmployees();
        void InsertEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
        IList<Employee> GetCurrentId();
    }
}

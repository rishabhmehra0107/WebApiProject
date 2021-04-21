using System.Collections.Generic;
using Models;
namespace Contracts
{
    public interface IOfficeService
    {
        IList<Office> GetAllOffices();
        void AddOffice(Office office);
        void UpdateOffice(Office office);
        void DeleteOffice(int id);
    }
}

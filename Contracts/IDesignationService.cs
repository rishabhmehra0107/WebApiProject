using System.Collections.Generic;
using Models;
namespace Contracts
{
    public interface IDesignationService
    {
        IList<Designation> GetAllDesignations();
        void AddDesignation(Designation designation);
        void UpdateDesignation(Designation designation);
        void DeleteDesignation(int id);
    }

}

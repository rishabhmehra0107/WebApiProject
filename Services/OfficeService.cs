using System;
using System.Collections.Generic;
using PetaPoco;
using Contracts;
using Models;
namespace Services
{
    public class OfficeService : IOfficeService
    {
        private readonly PetaPoco.Database connection;
        public OfficeService(PetaPoco.Database database)
        {
            this.connection = database;
        }

        public IList<Office> GetAllOffices()
        {
            string query = "SELECT * FROM Office";
            IList<Office> officeList = this.connection.Fetch<Office>(query);

            return officeList;
        }

        public void AddOffice(Office office)
        {

            this.connection.Insert("Office", "Id", true, office);
        }

        public void UpdateOffice(Office office)
        {
            this.connection.Update("Office", "Id", office);
        }

        public void DeleteOffice(int id)
        {
            this.connection.Delete<Office>(id);
        }
    }

}

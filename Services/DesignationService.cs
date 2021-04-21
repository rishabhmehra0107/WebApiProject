using System;
using System.Collections.Generic;
using PetaPoco;
using Contracts;
using Models;

namespace Services
{
    public class DesignationService : IDesignationService
    {
        private readonly PetaPoco.Database connection;
        public DesignationService(PetaPoco.Database database)
        {
            this.connection = database;
        }

        public IList<Designation> GetAllDesignations()
        {
            string query = "SELECT * FROM Designation";
            IList<Designation> designationtList = this.connection.Fetch<Designation>(query);

            return designationtList;
        }

        public void AddDesignation(Designation designation)
        {

            this.connection.Insert("Designation", "Id", true, designation);
        }

        public void UpdateDesignation(Designation designation)
        {
            this.connection.Update("Designation", "Id", designation);
        }

        public void DeleteDesignation(int id)
        {
            this.connection.Delete<Designation>(id);
        }
    }

}

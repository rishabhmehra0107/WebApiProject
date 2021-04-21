using System;
using System.Collections.Generic;
using PetaPoco;
using Microsoft.AspNetCore.Mvc;
using Contracts;
using Models;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("api/office")]
    public class OfficeController : Controller
    {
        public IOfficeService _officeService { get; set; }

        public OfficeController(IOfficeService officeServices)
        {
            this._officeService = officeServices;
        }

        [HttpGet]
        [Route("allofficedetails")]
        public IList<Office> GetOffices()
        {
            return _officeService.GetAllOffices();
        }

        [HttpPost]
        [Route("create")]
        public void AddOffice(Office office)
        {
            this._officeService.AddOffice(office);
        }

        [HttpPut]
        [Route("update")]
        public void UpdateOffice(Office office)
        {
            this._officeService.UpdateOffice(office);
        }

        [HttpDelete]
        public void DeleteOffice(int id)
        {
            this._officeService.DeleteOffice(id);
        }
    }

}

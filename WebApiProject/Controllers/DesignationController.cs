using System;
using System.Collections.Generic;
using PetaPoco;
using Microsoft.AspNetCore.Mvc;
using Contracts;
using Models;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("api/designation")]
    public class DesignationController : Controller
    {
        public IDesignationService _designationService { get; set; }

        public DesignationController(IDesignationService designationService)
        {
            this._designationService = designationService;
        }

        [HttpGet]
        [Route("alldesignationdetails")]
        public IList<Designation> GetDesignations()
        {
            return _designationService.GetAllDesignations();
        }

        [HttpPost]
        [Route("create")]
        public void AddDesignation(Designation designation)
        {
            this._designationService.AddDesignation(designation);
        }

        [HttpPut]
        [Route("update")]
        public void UpdateDepartment(Designation designation)
        {
            this._designationService.UpdateDesignation(designation);
        }

        [HttpDelete]
        public void DeleteDesignation(int id)
        {
            this._designationService.DeleteDesignation(id);
        }
    }

}

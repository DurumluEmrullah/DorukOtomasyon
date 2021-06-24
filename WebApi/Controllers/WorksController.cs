using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorksController :BaseController<IWorkService,Work>
    {
        private IWorkService _workService;

        public WorksController(IWorkService workService):base(workService)
        {

            _workService = workService;
        }

        [HttpGet("getallWorkDetails")]
        public IActionResult GetAll()
        {

            var result = _workService.GetAllWorkDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            
            return BadRequest(result.Message);
        }
        


    }
}

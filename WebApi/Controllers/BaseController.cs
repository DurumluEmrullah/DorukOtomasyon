using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Business.Abstract;
using Core.Entities.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController <TService, TEntity> : ControllerBase
        where TService : class, IBaseService<TEntity>
         where TEntity : class, IEntity, new()
    {
        private TService _services;

        public BaseController(TService services)
        {
            _services = services;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _services.GetAll();
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(TEntity entity)
        {
            var result = _services.Add(entity);
            if (result.Success)
                return Ok(result);

            return BadRequest(result.Message);
        }
    }
}

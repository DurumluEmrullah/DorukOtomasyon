using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : BaseController<IStatuService,Statu>
    {
        private IStatuService _statuService;

        public StatusController(IStatuService statuService):base(statuService)
        {
            _statuService = statuService;
        }
    }
}

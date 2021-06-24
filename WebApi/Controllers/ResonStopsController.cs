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
    public class ResonStopsController : BaseController<IResonStopService,ResonStop>
    {
        private IResonStopService _resonStopService;

        public ResonStopsController(IResonStopService resonStopService):base(resonStopService)
        {
            _resonStopService = resonStopService;
        }
    }
}

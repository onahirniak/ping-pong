using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pong.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PongController : ControllerBase
    {
        // GET api/pong
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Pong";
        }
    }
}

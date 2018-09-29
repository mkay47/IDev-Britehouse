using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Controllers
{
    [Produces("application/json")]
    [Route("api/[Controller]")]
    public class DataCleanupController : Controller
    {
        [Route("datacleanup")]
        [HttpGet()]
        public IActionResult DataCleanUp()
        {

            return NoContent();
        }

    }
}

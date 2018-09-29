using Hackathon.Orchestration.Interface;
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
        private readonly IDataCleanupOrchestration _DCOrchestration;

        public DataCleanupController(IDataCleanupOrchestration dcOrchestration)
        {
            _DCOrchestration = dcOrchestration;
        }

        [Route("datacleanup")]
        [HttpGet()]
        public IActionResult DataCleanUp()
        {
            var result = _DCOrchestration.CleanAndLoad();

            return Ok(result);
        }

    }
}

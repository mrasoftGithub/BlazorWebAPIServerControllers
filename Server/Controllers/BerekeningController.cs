using ErrorHandling.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ErrorHandling.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BerekeningController : ControllerBase
    {
        [HttpPost]
        [Route("DoeBerekening")]
        public async Task<ActionResult<Berekening>> DoeBerekening(Berekening berekening)
        {
            try
            {
                berekening.Uitkomst = Math.Round(berekening.Teller / berekening.Noemer, 2);
                await Task.Delay(0);
                return Ok(berekening);
            }
            catch(Exception e)
            {
                return Problem(statusCode: (int)HttpStatusCode.InternalServerError, 
                               detail: "Er is iets fout gegaan met uw berekening: " + e.Message);
            }
        }
    }
}

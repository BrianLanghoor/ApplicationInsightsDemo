using System;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationInsightsDemo.Controllers
{
    [ApiController]
    public class AiController : ControllerBase
    {
        // GET api/ai
        [HttpGet]
        [Route("api/succes")]
        public ActionResult<string> Succes()
        {
            return Ok("This request was succesfull");
        }

        [HttpGet]
        [Route("api/bad")]
        public ActionResult<string> Bad()
        {
            return BadRequest("This request was a bad request");
        }

        [HttpGet]
        [Route("api/unauthorized")]
        public ActionResult<string> UnAuthorized()
        {
            return Unauthorized("This request was unauthorized");
        }

        [HttpGet]
        [Route("api/exception")]
        public ActionResult<string> Exception()
        {
            throw new NotImplementedException("This method was not implemented");
        }
    }
}

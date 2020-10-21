using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CostlyNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloApiController : ControllerBase
    {

        private readonly ILogger<HelloApiController> _logger;

        public HelloApiController(ILogger<HelloApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(new Result("Hello from c#"));
        }
    }

    internal class Result
    {
        public string Response { get; set; }

        public Result(string Value)
        {
            Response = Value;
        }
    }
}

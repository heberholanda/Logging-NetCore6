using Microsoft.AspNetCore.Mvc;

namespace LoggingHttp.NetCore6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoggingController : ControllerBase
    {
        private readonly ILogger<LoggingController> _logger;

        public LoggingController(ILogger<LoggingController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Post([FromBody]KeyValueRequest request)
        {
            Response.Headers.Add("my-response-header", "My response header");
            return Ok(request);
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace hangfire_webApi.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class HangFireController : ControllerBase {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from hangfire web api");
        }
    }
}

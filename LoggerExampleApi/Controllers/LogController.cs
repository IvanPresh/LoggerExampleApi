using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoggerExampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly ILogger<LogController> _logger;

        public LogController(ILogger<LogController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult TestLog()
        {
           /* _logger.LogInformation("This is an Info log");

            _logger.LogError("An error occured");

            return Ok("Check your Logs");*/

            try
            {
                int number = 5;
                var result = number / 2;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "something happened", ex.Message);
               
                    return StatusCode(500);
            }
            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CarTrader.Services.Workflow.Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(
            IConfiguration configuration
        )
        {
            _configuration = configuration;
        }

        [HttpGet("")]
        public IActionResult Get() => Content("CarTrader.Services.Workflow " + _configuration["CPCLEANAPI_APP_VERSION"]  + " is working!");
    }
}
using Microsoft.AspNetCore.Mvc;

namespace CarTrader.Services.Cars.Api.Controllers
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
        public IActionResult Get() => Content("CarTrader.Services.Cars " + _configuration["CPCLEANAPI_APP_VERSION"]  + " is working!");
    }
}
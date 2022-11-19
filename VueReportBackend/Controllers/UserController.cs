using Microsoft.AspNetCore.Mvc;
using Model;

namespace VueReportBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public UserController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        public User Get() 
        {
            return new User 
            { 
                Id= 1,
                Login = "MyLogin",
                Password = "MyPassword"
            };
        }
    }
}

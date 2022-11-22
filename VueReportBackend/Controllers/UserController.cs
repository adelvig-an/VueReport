using Microsoft.AspNetCore.Mvc;
using Model;

namespace VueReportBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUser")]
        public User Get() 
        {
            return new User 
            { 
                Id= 1,
                Login = "Я из бэка берусь",
                Password = "Тут мой пароль"
            };
        }
    }
}

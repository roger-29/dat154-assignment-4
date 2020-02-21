using System;
using CustomerWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CustomerWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public bool Post(User user)
        {
            Console.WriteLine(user.Email);
            Console.WriteLine(user.Password);
            // Do some check if user is in database, if not create
            return true;
        }
    }
}

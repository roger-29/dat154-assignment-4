using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CustomerWebApp.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public User Post(User user)
        {
            // try to find user with this email in database, return if not create new
            return new User { UserNr = 123, Email = user.Email, Password = user.Password };
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerWebApp.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerWebApp.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseContext db;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            db = new DatabaseContext();
        }

        [HttpGet]
        public async Task<IEnumerable<Room>> Get()
        {
            // return all rooms with Avaliable = true;
            return await db.Rooms.ToListAsync();
        }
    }
}

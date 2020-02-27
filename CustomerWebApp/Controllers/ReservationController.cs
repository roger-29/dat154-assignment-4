using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerWebApp.Controllers
{
    [ApiController]
    [Route("api/reservation")]
    public class ReservationController : ControllerBase
    {
        private readonly ILogger<ReservationController> _logger;

        public ReservationController(ILogger<ReservationController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public IEnumerable<Room> Get(int id)
        {
            // Get all reservations with this userid find all rooms in reservations
            return new List<Room>
            {
                new Room { Roomnr = 1, Numberofbeds = 2, Roomsize = 25, Price = 1000, Available = false}
            }.ToArray();
        }

        [HttpPost]
        public void Post(Reservation reservation)
        {
            // Get all rooms, make this room Avaliable = false
            Reservation r = new Reservation { Roomnr = reservation.Roomnr, Usernr = reservation.Usernr };
            // Add reservation to database
        }
    }
}

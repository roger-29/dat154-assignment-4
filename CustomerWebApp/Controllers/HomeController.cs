﻿using System;
using System.Collections.Generic;
using System.Linq;
using HotelService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerWebApp.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Room> Get()
        {
            // return all rooms with Avaliable = true;
            return new List<Room> 
            {
                new Room { RoomNr = 1, NumberOfBeds = 2, RoomSize = 25, Price = 1000, Available = true},
                new Room { RoomNr = 2, NumberOfBeds = 2, RoomSize = 35, Price = 1500, Available = true},
                new Room { RoomNr = 3, NumberOfBeds = 2, RoomSize = 35, Price = 1500, Available = true},
                new Room { RoomNr = 4, NumberOfBeds = 3, RoomSize = 45, Price = 2000, Available = true},
                new Room { RoomNr = 5, NumberOfBeds = 3, RoomSize = 60, Price = 3000, Available = true}
            }.ToArray();
        }
    }
}

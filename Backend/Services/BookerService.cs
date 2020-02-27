using System.Threading.Tasks;
using Backend.Services;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace HotelService
{
	public class BookerService : Booking.BookingBase
	{
		private readonly ILogger<BookerService> _logger;
		private readonly DatabaseContext db;
		public BookerService(ILogger<BookerService> logger)
		{
			_logger = logger;
			db = new DatabaseContext();
			db.Add(new Room { RoomNr = 1, NumberOfBeds = 2, RoomSize = 25, Price = 1000, Available = true });
			db.Add(new Room { RoomNr = 2, NumberOfBeds = 2, RoomSize = 35, Price = 1500, Available = true });
			db.Add(new Room { RoomNr = 3, NumberOfBeds = 2, RoomSize = 35, Price = 1500, Available = true });
			db.Add(new Room { RoomNr = 4, NumberOfBeds = 3, RoomSize = 45, Price = 2000, Available = true });
			db.Add(new Room { RoomNr = 5, NumberOfBeds = 3, RoomSize = 60, Price = 3000, Available = true });
			db.SaveChanges();
		}

		public override Task<Reservation> RequestRoom(Reservation request, ServerCallContext context)
		{
			return Task.FromResult(new Reservation { });
		}
	}
}

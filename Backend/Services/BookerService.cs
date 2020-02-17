using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;


namespace HotelService
{
	public class BookerService : Booker.BookerBase
	{
		private readonly ILogger<BookerService> _logger;
		public BookerService(ILogger<BookerService> logger)
		{
			_logger = logger;
		}

		public override Task<Reservation> RequestRoom(Reservation request, ServerCallContext context)
		{
			return Task.FromResult(new Reservation { });
		}
	}
}

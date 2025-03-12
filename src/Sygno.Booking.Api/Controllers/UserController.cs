using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sygno.Booking.Application.Exceptions;
using Sygno.Booking.Application.Features;

namespace Sygno.Booking.Api.Controllers
{
    [Route("api/v1/user")]
    [ApiController]
	[TypeFilter(typeof(ExceptionManager))]
    public class UserController : ControllerBase
    {
		public UserController()
		{

		}

		[HttpPost]		
		public async Task<IActionResult> test()
		{
			var number = int.Parse("hola");

			return StatusCode(StatusCodes.Status200OK,
				ResponseApiService.Response(StatusCodes.Status200OK, "{}", "Ejecucion Exitosa"));
		}
	}
}

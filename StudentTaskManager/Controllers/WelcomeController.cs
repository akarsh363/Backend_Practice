using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentTaskManager.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WelcomeController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetWelcome()
		{
			return Ok("Welcome to my API!");
		}
	}
}

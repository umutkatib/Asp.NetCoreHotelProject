using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DefaultsController : ControllerBase
	{
		[HttpGet("[action]")]
		public IActionResult Test()
		{
			return Ok(new CreateJwtToken().CreateToken());
		}

		[HttpGet("[action]")]
		public IActionResult Test3Token()
		{
			return Ok(new CreateJwtToken().CreateTokenForAdmin());
		}

		[Authorize]
		[HttpGet("[action]")]
		public IActionResult Test2()
		{
			return Ok();
		}

		[Authorize(Roles = "Admin, Visitor")]
		[HttpGet("[action]")]
		public IActionResult Test3()
		{
			return Ok("Token Başarılı");
		}
	}
}

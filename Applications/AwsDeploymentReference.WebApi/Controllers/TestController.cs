using Microsoft.AspNetCore.Mvc;

namespace AwsDeploymentReference.WebApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TestController : ControllerBase
	{
		[HttpGet]
		public IActionResult Index()
		{
			return Ok("Hello World :)");
		}
	}
}

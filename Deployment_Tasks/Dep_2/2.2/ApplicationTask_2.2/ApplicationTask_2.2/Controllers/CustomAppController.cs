using Microsoft.AspNetCore.Mvc;

namespace ApplicationTask_2._2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomAppController : ControllerBase
    {
        [HttpGet]
        public string Get(string userName)
        {
            return $"Hello, {userName}. My name is Gayatri Sivasamboo S Jeyakumar and my student no. is 104546498!";
        }

        [HttpGet("/")]
        public string Home()
        {
            return "ApplicationTask 2.2 API is running!";
        }

    }
}

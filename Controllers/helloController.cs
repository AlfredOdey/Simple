using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;

namespace Simple_Web_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class helloController : ControllerBase
    {
        [HttpGet("")]
        public async Task<IActionResult> GetHello([FromQuery] string visitor_name)
        {
            string clientIp = HttpContext.Connection.RemoteIpAddress?.ToString();
            string location = "New York";
            int temperature = 11;
            var response = new
            {
                client_ip = clientIp ?? "127.0.0.1",
                location = location,
                greeting = $"Hello, {visitor_name}! The temperature is {temperature} degree Celsius in {location}."
            };
            return Ok(response);
        }
    }
}

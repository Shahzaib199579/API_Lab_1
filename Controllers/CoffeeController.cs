using API_Interactive_Lab_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        [HttpGet("{name}")]
        public Coffee Get(string? name)
        {
            return new Coffee(name);
        }

        [HttpGet("/lover")]
        public string Get()
        {
            return "I love coffee!";
        }
    }
}

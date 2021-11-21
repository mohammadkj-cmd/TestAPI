using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestAPIController : ControllerBase
    {
        //WeatherForecast
        private readonly ILogger<TestAPIController> _logger;
        public TestAPIController(ILogger<TestAPIController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }

        [HttpGet]
        [Route("GetPersonList")]
        public List<Person> GetPersonList()
        {
            return new List<Person> {
                new Person { id = 53, first = "Bill", last = "Bryson", Age = 23, gender = "M" },
                new Person { id = 62, first = "John", last = "Travolta", Age = 54, gender = "M" },
                new Person { id = 41, first = "Frank", last = "Zappa", Age = 23, gender = "T" },
                new Person { id = 31, first = "Jill", last = "Scott", Age = 66, gender = "Y" },
                new Person { id = 31, first = "Anna", last = "Meredith", Age = 66, gender = "Y" },
                new Person { id = 31, first = "Janet", last = "Jackson", Age = 23, gender = "F" }
            }; 
        }

    }
}
using Microsoft.AspNetCore.Mvc;

namespace webApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        
        [HttpGet("{firstNum}/{secondNum}")]
        public string Get(int firstNum, int secondNum)
        {
            var result = firstNum + secondNum;
            var parseMe = result.ToString();
            return parseMe;
        }

        
    }
}
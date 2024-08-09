using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Principal;

namespace Sample_api.Controllers
{

    public class TestController : ControllerBase
    {
        public TestController() { }

        [HttpGet("get")]
        public async Task<IActionResult> Get()
        {
            string filePath = @"FakeData/Test/get.json";

            string line = "";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string _temp = reader.ReadLine();
                if (_temp != null)
                { 
                    line = _temp; 
                }
            }


            return Ok(line);
        }
    }
}

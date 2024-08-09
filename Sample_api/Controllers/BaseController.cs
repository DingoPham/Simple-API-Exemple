using Microsoft.AspNetCore.Mvc;

namespace Sample_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController : ControllerBase
    {
        public BaseController()
        {
        }
    }
}

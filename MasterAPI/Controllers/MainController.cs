using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MasterAPI.Controllers
{
    [Route("api/Main")]
    [ApiController]
    public class MainController : ControllerBase
    {

        [HttpGet]   
        public string Get()
        {
            return "Main API Values"; 
        }
    }
}

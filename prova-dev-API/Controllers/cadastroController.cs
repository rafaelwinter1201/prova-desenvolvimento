using Microsoft.AspNetCore.Mvc;

namespace prova_dev_API.Controllers
{
        [ApiController]
        [Route("[controller]")]
        public class cadastroController : ControllerBase{
            [HttpGet]
            public IActionResult Get(){
                return Ok("ok");
            }
        }
    }
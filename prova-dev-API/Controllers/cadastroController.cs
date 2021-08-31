using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using prova_dev_API.Data;

namespace prova_dev_API.Controllers
{
        [ApiController]
        [Route("[controller]")]
        public class cadastroController : ControllerBase{
        private readonly IRpository _repo;

        public cadastroController(IRpository repo) {
            _repo = repo;
        }

        [HttpGet]
            public async Task<IActionResult> Get(){
                try
                {
                    var result = await _repo.GetAllcadastroAsync(true);
                    return Ok("ok");
                }
                catch (Exception ex)
                {
                    return BadRequest($"Erro: {ex.Message}");
                }
                
            }
            
        }
    }
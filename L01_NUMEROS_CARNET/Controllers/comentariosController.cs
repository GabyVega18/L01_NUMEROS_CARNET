using L01_NUMEROS_CARNET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L01_NUMEROS_CARNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class comentariosController : ControllerBase
    {
        private readonly blogDBContext _blogDBContexto;

        public comentariosController(blogDBContext blogDBContexto)
        {
            _blogDBContexto = blogDBContexto;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<comentarios> Listadocomentarios = _blogDBContexto.comentarios.ToList();

            if (Listadocomentarios.Count == 0) 
            {
                return NotFound();
            }

            return Ok(Listadocomentarios);
        }
    }
}

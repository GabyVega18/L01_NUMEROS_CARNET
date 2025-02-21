using L01_NUMEROS_CARNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace L01_NUMEROS_CARNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuariosController : ControllerBase
    {
        private readonly blogDBContext _blogDBContexto;

        public usuariosController(blogDBContext blogDBContexto)
        {
            _blogDBContexto = blogDBContexto;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<usuarios> Listadousuarios = _blogDBContexto.usuarios.ToList();

            if (Listadousuarios.Count == 0) 
            {
                return NotFound();
            }

            return Ok(Listadousuarios);
        }
    }
}

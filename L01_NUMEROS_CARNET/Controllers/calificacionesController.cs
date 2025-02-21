using L01_NUMEROS_CARNET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L01_NUMEROS_CARNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class calificacionesController : ControllerBase
    {
        private readonly blogDBContext _blogDBContexto;

        public calificacionesController(blogDBContext blogDBContexto)
        {
            _blogDBContexto = blogDBContexto;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<calificaciones> Listadocalificaciones = _blogDBContexto.calificaciones.ToList();

            if (Listadocalificaciones.Count == 0) 
            {
                return NotFound();
            }

            return Ok(Listadocalificaciones);
        }
    }
}


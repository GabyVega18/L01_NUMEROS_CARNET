using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using L01_NUMEROS_CARNET.Models;
using Microsoft.EntityFrameworkCore;

namespace L01_NUMEROS_CARNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class blogDBController : ControllerBase
    {
        private readonly blogDBContext _blogDBContexto;
        public blogDBController(blogDBContext blogDBContexto)
        {
            _blogDBContexto = blogDBContexto;
        }
    }
}

using Mapper.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Mapper.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("{nome}")]
        public IActionResult Get(string nome)
        {
            Usuario usuario = new Usuario(nome);
            return Ok(usuario);
        }
    }
}
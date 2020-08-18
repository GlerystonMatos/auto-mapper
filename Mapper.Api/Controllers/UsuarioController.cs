using Mapper.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Mapper.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
            => _usuarioService = usuarioService;

        [HttpGet("{nome}")]
        public IActionResult Get(string nome)
            => Ok(_usuarioService.FindByNome(nome));

        [HttpGet]
        public IActionResult Get()
            => Ok(_usuarioService.GetAll());
    }
}
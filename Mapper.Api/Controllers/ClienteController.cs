using Mapper.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Mapper.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        [HttpGet("{nome}")]
        public IActionResult Get(string nome)
        {
            Cliente cliente = new Cliente(nome);
            return Ok(cliente);
        }
    }
}
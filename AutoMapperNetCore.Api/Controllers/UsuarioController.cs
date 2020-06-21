using AutoMapper;
using AutoMapperNetCore.Domain.Dto;
using AutoMapperNetCore.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperNetCore.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IMapper _mapper;

        public UsuarioController(IMapper mapper)
            => _mapper = mapper;

        [HttpGet]
        public IActionResult Get()
        {
            Usuario usuario = new Usuario("Gleryston");
            return Ok(_mapper.Map<UsuarioDto>(usuario));
        }
    }
}
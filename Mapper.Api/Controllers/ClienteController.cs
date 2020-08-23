using AutoMapper;
using Mapper.Api.Dto;
using Mapper.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Mapper.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ClienteController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("{nome}")]
        public IActionResult Get(string nome)
        {
            Cliente cliente = new Cliente(nome);
            return Ok(_mapper.Map<ClienteDto>(cliente));
        }
    }
}
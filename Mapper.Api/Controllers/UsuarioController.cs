using AutoMapper;
using AutoMapper.QueryableExtensions;
using Mapper.Api.Context;
using Mapper.Api.Dto;
using Mapper.Api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Mapper.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly MapperContext _context;

        public UsuarioController(IMapper mapper, MapperContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet("{nome}")]
        public IActionResult Get(string nome)
            => Ok(_context.Set<Usuario>().Where(u => u.Nome.Equals(nome)).Include(u => u.Perfil).ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider).AsQueryable());

        [HttpGet]
        public IActionResult Get()
            => Ok(_context.Set<Usuario>().Include(u => u.Perfil).ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider).AsQueryable());
    }
}
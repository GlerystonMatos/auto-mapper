using AutoMapper;
using AutoMapper.QueryableExtensions;
using Mapper.Data.Comun;
using Mapper.Data.Context;
using Mapper.Domain.Dto;
using Mapper.Domain.Entities;
using Mapper.Domain.Interfaces.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Mapper.Data.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        private readonly IMapper _mapper;

        public UsuarioRepository(MapperContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public IQueryable<UsuarioDto> GetAll()
            => _context.Set<Usuario>().Include(p => p.Perfil).AsQueryable().ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider);

        public UsuarioDto FindByNome(string nome)
            => _context.Set<Usuario>().Where(u => u.Nome.Equals(nome)).ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider).FirstOrDefault();
    }
}
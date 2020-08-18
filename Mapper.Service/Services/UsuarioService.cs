using AutoMapper;
using Mapper.Domain.Dto;
using Mapper.Domain.Entities;
using Mapper.Domain.Interfaces.Data;
using Mapper.Domain.Interfaces.Services;
using System.Linq;

namespace Mapper.Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IMapper mapper, IUsuarioRepository usuarioRepository)
        {
            _mapper = mapper;
            _usuarioRepository = usuarioRepository;
        }

        public UsuarioDto GetUsuario(string nome)
        {
            Usuario usuario = new Usuario(nome);
            usuario.Perfil = new Perfil("Administrador");
            return _mapper.Map<UsuarioDto>(usuario);
        }

        public IQueryable<UsuarioDto> GetAll()
            => _usuarioRepository.GetAll();

        public UsuarioDto FindByNome(string nome)
            => _usuarioRepository.FindByNome(nome);
    }
}
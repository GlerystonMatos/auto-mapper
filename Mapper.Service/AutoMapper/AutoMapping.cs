using AutoMapper;
using Mapper.Domain.Dto;
using Mapper.Domain.Entities;

namespace Mapper.Service.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Usuario, UsuarioDto>()
                .ReverseMap();

            CreateMap<Perfil, PerfilDto>()
                .ReverseMap();
        }
    }
}
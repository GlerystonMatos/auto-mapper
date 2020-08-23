using AutoMapper;
using Mapper.Api.Dto;
using Mapper.Api.Entities;

namespace Mapper.Api.AutoMapper
{
    public class ConfigurationMapping : Profile
    {
        public ConfigurationMapping()
        {
            CreateMap<Cliente, ClienteDto>()
                .ReverseMap();

            CreateMap<Usuario, UsuarioDto>()
                .ForMember(dto => dto.Senha, opt => opt.MapFrom(u => u.Id.ToString().Replace("-", "").ToLower()))
                .ForMember(dto => dto.Status, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<Perfil, PerfilDto>()
                .ReverseMap();
        }
    }
}
using AutoMapper;
using AutoMapperNetCore.Domain.Dto;
using AutoMapperNetCore.Domain.Entities;

namespace AutoMapperNetCore.Api.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Usuario, UsuarioDto>().
                ReverseMap();
        }
    }
}
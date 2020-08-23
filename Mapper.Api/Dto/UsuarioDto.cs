using System;

namespace Mapper.Api.Dto
{
    public class UsuarioDto : Dto
    {
        public UsuarioDto(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public string Nome { get; set; }

        public PerfilDto Perfil { get; set; }
    }
}
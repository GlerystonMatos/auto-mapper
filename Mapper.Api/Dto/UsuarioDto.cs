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

        public string Senha { get; set; }

        public string Status
        {
            get
            {
                return "Ativo";
            }
            set
            {
            }
        }
    }
}
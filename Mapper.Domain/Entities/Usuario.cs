using System;

namespace Mapper.Domain.Entities
{
    public class Usuario : Entity
    {
        public Usuario(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public string Nome { get; set; }

        public Guid IdPerfil { get; set; }

        public Perfil Perfil { get; set; }
    }
}
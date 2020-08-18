using System;
using System.Collections.Generic;

namespace Mapper.Domain.Entities
{
    public class Perfil : Entity
    {
        public Perfil(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public string Nome { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}
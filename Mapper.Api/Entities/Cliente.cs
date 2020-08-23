using System;

namespace Mapper.Api.Entities
{
    public class Cliente : Entity
    {
        public Cliente(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public string Nome { get; set; }
    }
}
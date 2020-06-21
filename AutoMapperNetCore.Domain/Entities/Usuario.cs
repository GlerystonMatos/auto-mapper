using System;

namespace AutoMapperNetCore.Domain.Entities
{
    public class Usuario
    {
        public Usuario(string nome)
        {
            Id = Guid.NewGuid(); ;
            Nome = nome;
        }

        public Guid Id { get; }

        public string Nome { get; }
    }
}
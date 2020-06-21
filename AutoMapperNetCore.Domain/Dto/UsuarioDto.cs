using System;

namespace AutoMapperNetCore.Domain.Dto
{
    public class UsuarioDto
    {
        public UsuarioDto(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public Guid Id { get; }

        public string Nome { get; }
    }
}
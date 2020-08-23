using System;

namespace Mapper.Api.Dto
{
    public class ClienteDto : Dto
    {
        public ClienteDto(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public string Nome { get; set; }
    }
}
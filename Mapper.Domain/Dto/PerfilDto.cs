﻿using System;

namespace Mapper.Domain.Dto
{
    public class PerfilDto : Dto
    {
        public PerfilDto(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public string Nome { get; set; }
    }
}
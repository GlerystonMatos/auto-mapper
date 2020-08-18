using Mapper.Domain.Dto;
using Mapper.Domain.Entities;
using Mapper.Domain.Interfaces.Commun;
using System.Linq;

namespace Mapper.Domain.Interfaces.Data
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        IQueryable<UsuarioDto> GetAll();

        UsuarioDto FindByNome(string nome);
    }
}
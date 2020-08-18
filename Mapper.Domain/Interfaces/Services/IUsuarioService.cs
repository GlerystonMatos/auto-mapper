using Mapper.Domain.Dto;
using Mapper.Domain.Interfaces.Commun;
using System.Linq;

namespace Mapper.Domain.Interfaces.Services
{
    public interface IUsuarioService : IService<UsuarioDto>
    {
        UsuarioDto GetUsuario(string nome);

        IQueryable<UsuarioDto> GetAll();

        UsuarioDto FindByNome(string nome);
    }
}
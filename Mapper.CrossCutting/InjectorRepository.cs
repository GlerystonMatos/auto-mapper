using Mapper.Data.Repositories;
using Mapper.Domain.Interfaces.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Mapper.CrossCutting
{
    public static class InjectorRepository
    {
        public static void RegisterRepository(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
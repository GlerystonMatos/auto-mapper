using Mapper.Domain.Interfaces.Services;
using Mapper.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Mapper.CrossCutting
{
    public static class InjectorService
    {
        public static void RegisterService(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();
        }
    }
}
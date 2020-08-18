using Mapper.Data.Context;
using Microsoft.Extensions.DependencyInjection;

namespace Mapper.CrossCutting
{
    public static class InjectorDependencies
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.RegisterService();
            services.RegisterRepository();
            services.AddScoped<MapperContext>();
        }
    }
}
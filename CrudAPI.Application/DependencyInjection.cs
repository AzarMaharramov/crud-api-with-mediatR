using CrudAPI.Application.Features.Mappings;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CrudAPI.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile).Assembly);

            services.AddMediatR(cfg => { cfg.RegisterServicesFromAssemblies(typeof(DependencyInjection).Assembly, Assembly.GetExecutingAssembly()); });

            return services;
        }
    }
}

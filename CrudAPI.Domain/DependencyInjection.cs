using Microsoft.Extensions.DependencyInjection;

namespace CrudAPI.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            /*
            services.AddDbContext<AppDB>(options =>
                                         options.UseNpgsql(configuration.GetConnectionString("LibraryDB")));
            */
            return services;
        }
    }
}

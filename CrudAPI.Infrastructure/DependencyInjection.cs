using CrudAPI.Domain.Common.Interfaces.IRepositories;
using CrudAPI.Domain.Entities;
using CrudAPI.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CrudAPI.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            #region ConnectionString

            //services.AddSingleton<DbConnectionFactory>(x => new DbConnectionFactory(configuration.GetConnectionString("LibraryDB")));
            services.AddDbContext<AppDB>(options => options.UseNpgsql(configuration.GetConnectionString("LibraryDB")));

            #endregion

            #region Repositories

            services.AddScoped(typeof(IBookRepository), typeof(BookRepository));

            #endregion

        }
    }
}

using CrudAPI.Application.Common.Interfaces.IRepositories;
using CrudAPI.Infrastructure.Persistence;
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

            services.AddDbContext<EfDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("LibraryDB")));
            
            #endregion

            #region Repositories

            services.AddScoped(typeof(IBookRepository), typeof(BookRepository));

            #endregion

        }
    }
}

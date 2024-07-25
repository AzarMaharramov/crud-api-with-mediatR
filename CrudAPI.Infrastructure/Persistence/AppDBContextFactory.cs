using CrudAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CrudAPI.Infrastructure.Persistence
{
    public class AppDBContextFactory : IDesignTimeDbContextFactory<AppDB>
    {
        public AppDB CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDB>();
            optionsBuilder.UseNpgsql("LibraryDB");

            return new AppDB(optionsBuilder.Options);
        }
    }
}

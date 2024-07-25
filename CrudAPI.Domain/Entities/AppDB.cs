using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Domain.Entities
{
    public class AppDB : DbContext
    {
        public AppDB(DbContextOptions<AppDB> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}

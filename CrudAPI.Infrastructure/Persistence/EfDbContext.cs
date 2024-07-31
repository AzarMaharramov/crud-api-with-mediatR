using CrudAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Infrastructure.Persistence
{
    public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                        .Property(b => b.Created)
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}

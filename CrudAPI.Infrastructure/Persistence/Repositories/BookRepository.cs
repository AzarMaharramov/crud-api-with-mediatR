using CrudAPI.Application.Common.Interfaces.IRepositories;
using CrudAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Infrastructure.Persistence.Repositories
{
    public sealed class BookRepository : IBookRepository
    {
        private readonly EfDbContext _context;
        public BookRepository(EfDbContext context) => _context = context;

        public async Task<Book?> Get(long id)
        {
            return await _context.Books.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<List<Book>> GetAll()
        {
            return await _context.Books.AsNoTracking().ToListAsync();
        }
        
        public async Task Insert(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
                throw new KeyNotFoundException($"Book with ID {id} not found.");

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }
    }
}

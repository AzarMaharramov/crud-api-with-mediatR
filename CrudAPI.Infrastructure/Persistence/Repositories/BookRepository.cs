using CrudAPI.Domain.Common.Interfaces.IRepositories;
using CrudAPI.Domain.Entities;

namespace CrudAPI.Infrastructure.Persistence.Repositories
{
    public sealed class BookRepository : IBookRepository
    {
        
        public async Task<Book> Get(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Book>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task Insert(Book book)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Book book)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}

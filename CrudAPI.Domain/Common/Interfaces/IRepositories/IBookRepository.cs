using CrudAPI.Domain.Entities;

namespace CrudAPI.Domain.Common.Interfaces.IRepositories
{
    public interface IBookRepository
    {
        Task<Book> Get(long id);
        Task<List<Book>> GetAll();
        Task Insert(Book book);
        Task Update(Book book);
        Task Delete(long id);
    }
}

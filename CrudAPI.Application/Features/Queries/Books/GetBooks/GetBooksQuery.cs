using CrudAPI.Application.DTOs.Response.Books;
using MediatR;

namespace CrudAPI.Application.Features.Queries.Books.GetBooks
{
    public class GetBooksQuery : IRequest<List<GetBooksResDto>> { }
}

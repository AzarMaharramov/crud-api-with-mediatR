using CrudAPI.Application.DTOs.Response.Books;
using MediatR;

namespace CrudAPI.Application.Features.Queries.Books.GetBook
{
    public class GetBookQuery : IRequest<GetBookResDto>
    {
        public long Id { get; set; }
    }
}

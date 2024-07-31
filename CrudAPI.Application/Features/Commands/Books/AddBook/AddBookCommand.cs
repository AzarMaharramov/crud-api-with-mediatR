using CrudAPI.Application.DTOs.Request.Books;
using MediatR;

namespace CrudAPI.Application.Features.Commands.Books.AddBook
{
    public class AddBookCommand : IRequest<Unit>
    {
        public AddBookReqDto Request { get; set; } = null!;
    }
}

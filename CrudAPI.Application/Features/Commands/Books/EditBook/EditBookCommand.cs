using CrudAPI.Application.DTOs.Request.Books;
using MediatR;

namespace CrudAPI.Application.Features.Commands.Books.EditBook
{
    public class EditBookCommand : IRequest<Unit>
    {
        public EditBookReqDto Request { get; set; } = null!;
    }
}

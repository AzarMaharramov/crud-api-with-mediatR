using MediatR;

namespace CrudAPI.Application.Features.Commands.Books.DeleteBook
{
    public class DeleteBookCommand : IRequest<Unit>
    {
        public long Id { get; set; }
    }
}

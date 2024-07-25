using CrudAPI.Domain.Common.Interfaces.IRepositories;
using MediatR;

namespace CrudAPI.Application.Features.Commands.Books.DeleteBook
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, Unit>
    {
        private readonly IBookRepository _bookRepository;

        public DeleteBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            await _bookRepository.Delete(request.Id);

            return Unit.Value;
        }
    }
}

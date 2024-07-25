using AutoMapper;
using CrudAPI.Domain.Common.Interfaces.IRepositories;
using CrudAPI.Domain.Entities;
using MediatR;

namespace CrudAPI.Application.Features.Commands.Books.AddBook
{
    public class AddBookCommandHandler : IRequestHandler<AddBookCommand, Unit>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public AddBookCommandHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            var book = _mapper.Map<Book>(request.Request);
            await _bookRepository.Insert(book);

            return Unit.Value;
        }
    }
}

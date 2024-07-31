using AutoMapper;
using CrudAPI.Application.Common.Interfaces.IRepositories;
using CrudAPI.Domain.Entities;
using MediatR;

namespace CrudAPI.Application.Features.Commands.Books.EditBook
{
    public class EditBookCommandHandler : IRequestHandler<EditBookCommand, Unit>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public EditBookCommandHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(EditBookCommand request, CancellationToken cancellationToken)
        {
            Book? book = await _bookRepository.Get(request.Request.Id);

            _mapper.Map(book, request.Request);
            await _bookRepository.Update(book);

            return Unit.Value;
        }
    }
}

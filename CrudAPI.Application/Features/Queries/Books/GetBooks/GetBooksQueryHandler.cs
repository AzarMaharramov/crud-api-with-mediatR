using AutoMapper;
using CrudAPI.Application.DTOs.Response.Books;
using CrudAPI.Application.Common.Interfaces.IRepositories;
using MediatR;

namespace CrudAPI.Application.Features.Queries.Books.GetBooks
{
    public class GetBooksQueryHandler : IRequestHandler<GetBooksQuery, List<GetBooksResDto>>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public GetBooksQueryHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<List<GetBooksResDto>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await _bookRepository.GetAll();

            var response = _mapper.Map<List<GetBooksResDto>>(books);

            return response;
        }
    }
}

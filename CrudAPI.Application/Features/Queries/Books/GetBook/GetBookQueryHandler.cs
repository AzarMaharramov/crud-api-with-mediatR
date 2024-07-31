using AutoMapper;
using CrudAPI.Application.DTOs.Response.Books;
using CrudAPI.Application.Common.Interfaces.IRepositories;
using MediatR;

namespace CrudAPI.Application.Features.Queries.Books.GetBook
{
    public class GetBookQueryHandler : IRequestHandler<GetBookQuery, GetBookResDto>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public GetBookQueryHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<GetBookResDto> Handle(GetBookQuery request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.Get(request.Id);
            
            var response = _mapper.Map<GetBookResDto>(book);
            
            return response;
        }
    }
}

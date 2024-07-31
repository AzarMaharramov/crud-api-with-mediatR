using AutoMapper;
using CrudAPI.Application.DTOs.Request.Books;
using CrudAPI.Application.DTOs.Response.Books;
using CrudAPI.Domain.Entities;

namespace CrudAPI.Application.Features.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Book

            CreateMap<AddBookReqDto, Book>().ReverseMap();
            CreateMap<EditBookReqDto, Book>()
                .ForMember(dest => dest.Updated, 
                            opt => opt.MapFrom
                           (src => DateTime.UtcNow))
                .ReverseMap();

            CreateMap<Book, GetBookResDto>().ReverseMap();
            CreateMap<Book, GetBooksResDto>().ReverseMap();

            #endregion
        }
    }
}

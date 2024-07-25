using AutoMapper;
using CrudAPI.Application.DTOs.Request.Books;
using CrudAPI.Application.DTOs.Response.Books;
using CrudAPI.Domain.Entities;
using Microsoft.AspNetCore.Routing.Constraints;

namespace CrudAPI.Application.Features.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Book

            CreateMap<AddBookReqDto, Book>().ReverseMap(); ;
            CreateMap<EditBookReqDto, Book>().ReverseMap(); ;

            CreateMap<Book, GetBookResDto>()
                //.ForMember(src => { src.BookGenre = src })
                .ReverseMap();

            CreateMap<Book, GetBooksResDto>().ReverseMap(); ;

            #endregion
        }
    }
}

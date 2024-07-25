using CrudAPI.Domain.Entities;

namespace CrudAPI.Application.DTOs.Request.Books
{
    public sealed class AddBookReqDto
    {
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public BookGenre BookGenre { get; set; }
    }
}

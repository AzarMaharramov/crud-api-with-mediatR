namespace CrudAPI.Application.DTOs.Response.Books
{
    public sealed class GetBooksResDto
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string BookGenre { get; set; } = null!;
        public DateTime Created { get; set; }
    }
}

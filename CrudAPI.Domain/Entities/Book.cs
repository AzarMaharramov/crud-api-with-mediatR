using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudAPI.Domain.Entities
{
    [Table("books", Schema = "cmn")]
    public class Book : BaseEntity
    {
        [Required, MaxLength(50), Column("title")]
        public string Title { get; set; } = null!;
        
        [MaxLength(250), Column("description")]
        public string? Description { get; set; }

        [Column("book_genre")]
        public BookGenre BookGenre { get; set; }
    }

    public enum BookGenre
    {
           None = 0,
         Horror = 1,
          Fable = 2,
        Fiction = 3,
        Mystery = 4
    }
}

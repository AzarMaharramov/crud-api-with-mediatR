using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Domain.Entities
{
    public class Book : BaseEntity
    {
        [Required, MaxLength(50)]
        public string Title { get; set; } = null!;
        
        [MaxLength(250)]
        public string? Description { get; set; }
        
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

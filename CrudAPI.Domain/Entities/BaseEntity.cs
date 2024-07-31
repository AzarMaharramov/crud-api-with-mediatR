using System.ComponentModel.DataAnnotations.Schema;

namespace CrudAPI.Domain.Entities
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
        
        [Column("created_date")]
        public DateTime Created { get; set; }
        
        [Column("updated_date")]
        public DateTime? Updated { get; set; }
    }
}

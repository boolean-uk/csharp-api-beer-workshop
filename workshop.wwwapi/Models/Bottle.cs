using System.ComponentModel.DataAnnotations.Schema;

namespace workshop.wwwapi.Models
{
    [Table("bottles")]
    public class Bottle
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("brand")]
        public string Brand { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace workshop.wwwapi.Models
{
    //[PrimaryKey(nameof(StudentId), nameof(BottleId))]
    [Table("fridge")]
    public class Fridge
    {        
        [Column("studentid")]
        [ForeignKey("Student")]
        public int StudentId { get; set; }
      
        [Column("bottleid")]
        [ForeignKey("Bottle")]
        public int BottleId { get; set; }
       
        
    }
}

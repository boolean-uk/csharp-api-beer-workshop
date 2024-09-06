using System.ComponentModel.DataAnnotations.Schema;

namespace workshop.wwwapi.ViewModels
{
    [NotMapped]
    public class BottlePostModel
    {
        public string Brand { get; set; }
        public int Size { get; set; }
        public int StudentId { get; set; }
    }
}
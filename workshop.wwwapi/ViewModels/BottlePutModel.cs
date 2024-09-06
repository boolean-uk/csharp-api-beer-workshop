using System.ComponentModel.DataAnnotations.Schema;

namespace workshop.wwwapi.ViewModels
{
    [NotMapped]
    public class BottlePutModel
    {
        public string Brand { get; set; }
    }
}

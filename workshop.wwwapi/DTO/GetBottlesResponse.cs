using System.ComponentModel.DataAnnotations.Schema;

namespace workshop.wwwapi.DTO
{
    [NotMapped]
    public class GetBottlesResponse
    {
        public List<DTOBottle> Bottles { get; set; } = new List<DTOBottle>();
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using workshop.wwwapi.Models;

namespace workshop.wwwapi.DTO
{
    [NotMapped]
    public class DTOBottle
    {
        public string Brand { get; set; }
        public DTOStudent Owner { get; set; }
    }
}

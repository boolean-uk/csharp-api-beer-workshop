using workshop.wwwapi.Models;

namespace workshop.wwwapi.Repository
{
    public interface IFridgeRepository
    {
        Task<List<Fridge>> GetFridgeContents();
    }
}

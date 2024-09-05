using workshop.wwwapi.Models;

namespace workshop.wwwapi.Repository
{
    public interface IBottleRepository
    {
        Task<List<Bottle>> GetBottles();
        Task<Bottle> AddBottle(Bottle entity);
        Task<Bottle> GetById(int id);
        Task<Bottle> UpdateById(int id,  Bottle entity);
    }
}

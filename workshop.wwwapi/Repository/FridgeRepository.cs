using Microsoft.EntityFrameworkCore;
using workshop.wwwapi.Data;
using workshop.wwwapi.Models;

namespace workshop.wwwapi.Repository
{
    public class FridgeRepository : IFridgeRepository
    {
        private DataContext _db;
        public FridgeRepository(DataContext db)
        {
            _db = db;
        }
        public async Task<List<Fridge>> GetFridgeContents()
        {
            throw new NotImplementedException();
            //return await _db.FridgeContents.Include(x => x.Student).Include(x => x.Bottle).ToListAsync();
        }
    }
}

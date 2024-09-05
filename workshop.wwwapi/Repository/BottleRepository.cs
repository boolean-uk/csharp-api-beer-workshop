using Microsoft.EntityFrameworkCore;
using workshop.wwwapi.Data;
using workshop.wwwapi.Models;

namespace workshop.wwwapi.Repository
{
    public class BottleRepository : IBottleRepository
    {
        private DataContext _db;

        public BottleRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<Bottle> AddBottle(Bottle entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<List<Bottle>> GetBottles()
        {
            return await _db.Bottles.Include(bottle => bottle.Owner).ToListAsync();
        }

        public async Task<Bottle> GetById(int id)
        {
            var entity = await _db.Bottles.FirstOrDefaultAsync(b => b.Id == id);
            return entity;
        }

        public async Task<Bottle> UpdateById(int id, Bottle entity)
        {            
            _db.Attach(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}

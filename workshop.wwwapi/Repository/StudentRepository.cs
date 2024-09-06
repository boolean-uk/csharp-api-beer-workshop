using Microsoft.EntityFrameworkCore;
using workshop.wwwapi.Data;
using workshop.wwwapi.Models;

namespace workshop.wwwapi.Repository
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudents();
    }
    public class StudentRepository : IStudentRepository
    {
        private DataContext _db;
        public StudentRepository(DataContext db)
        {
            _db = db;
        }
        public async Task<List<Student>> GetStudents()
        {
            return await _db.Students.ToListAsync();
        }
    }
}

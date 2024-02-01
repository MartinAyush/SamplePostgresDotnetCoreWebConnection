using SamplePostgresConnection.Api.DAO;
using SamplePostgresConnection.Api.Models;

namespace SamplePostgresConnection.Api.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly CrudAppDbContext _dbContext;

        public StudentRepository(CrudAppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public List<Student> GetAll()
        {
            var students = _dbContext.Students.ToList();
            return students;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SamplePostgresConnection.Api.Models;

namespace SamplePostgresConnection.Api.DAO
{
    public class CrudAppDbContext : DbContext
    {
        public CrudAppDbContext(DbContextOptions<CrudAppDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }  
    }
}

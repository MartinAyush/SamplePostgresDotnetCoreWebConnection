using Microsoft.AspNetCore.SignalR;
using SamplePostgresConnection.Api.Models;

namespace SamplePostgresConnection.Api.Repositories
{
    public interface IStudentRepository
    {
        public List<Student> GetAll();
    }
}

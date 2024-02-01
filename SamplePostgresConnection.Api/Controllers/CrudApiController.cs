using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SamplePostgresConnection.Api.DAO;
using SamplePostgresConnection.Api.Repositories;

namespace SamplePostgresConnection.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudApiController : ControllerBase
    {
        private readonly StudentRepository _studentRepository;

        public CrudApiController(CrudAppDbContext dbContext) 
        {
            this._studentRepository = new StudentRepository(dbContext);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var students = _studentRepository.GetAll();
            return Ok(students);
        }
    }
}

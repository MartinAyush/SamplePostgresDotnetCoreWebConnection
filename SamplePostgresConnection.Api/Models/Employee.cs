namespace SamplePostgresConnection.Api.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? Designation { get; set; }
        public string? Email { get; set; }

    }
}

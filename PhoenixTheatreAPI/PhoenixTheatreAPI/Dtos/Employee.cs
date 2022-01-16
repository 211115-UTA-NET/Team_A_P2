namespace PhoenixTheatreAPI.Dtos
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string IsManager { get; set; }
        public int TheatreId { get; set; }
    }
}

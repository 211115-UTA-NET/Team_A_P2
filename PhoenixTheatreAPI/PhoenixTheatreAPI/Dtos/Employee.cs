namespace PhoenixTheatreAPI.Dtos
{
    public class Employee
    {
        Guid EmployeeId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string IsManager { get; set; }
        int TheatreId { get; set; }
    }
}

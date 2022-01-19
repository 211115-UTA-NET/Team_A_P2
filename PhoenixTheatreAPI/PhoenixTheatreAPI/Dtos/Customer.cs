namespace PhoenixTheatreAPI.Dtos
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
    }
}

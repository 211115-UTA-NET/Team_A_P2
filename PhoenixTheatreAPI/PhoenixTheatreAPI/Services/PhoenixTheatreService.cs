using Microsoft.EntityFrameworkCore;
using PhoenixTheatreAPI.Data;
using PhoenixTheatreAPI.Dtos;

namespace PhoenixTheatreAPI.Services
{
    public class PhoenixTheatreService
    {
        private readonly PhoenixTheatreContext _context;
        public  PhoenixTheatreService(PhoenixTheatreContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetCustomerByName(string firstName, string lastName)
        {
            return _context.Customer;
        }
    }
}

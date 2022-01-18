using Microsoft.EntityFrameworkCore;
using PhoenixTheatreAPI.Dtos;

namespace PhoenixTheatreAPI.Data
{
    public class PhoenixTheatreContext : DbContext
    {
        public PhoenixTheatreContext(DbContextOptions<PhoenixTheatreContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customer => Set<Customer>();
    }
}

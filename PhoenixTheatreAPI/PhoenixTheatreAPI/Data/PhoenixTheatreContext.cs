using Microsoft.EntityFrameworkCore;
using PhoenixTheatreAPI.Dtos;

namespace PhoenixTheatreAPI.Data
{
    public class PhoenixTheatreContext : DbContext
    {
        public PhoenixTheatreContext() { }
        public PhoenixTheatreContext(DbContextOptions<PhoenixTheatreContext> options) : base(options)
        {

        }

        //public DbSet<TheatreFilms> TheatreFilms => Set<TheatreFilms>();
        public virtual DbSet<FilmShowings> FilmShowings => Set<FilmShowings>();
        public virtual DbSet<CustomerOrder> Orders => Set<CustomerOrder>();
        public virtual DbSet<Customer> Customer => Set<Customer>();
        public virtual DbSet<Employee> Employee => Set<Employee>();
    }
}

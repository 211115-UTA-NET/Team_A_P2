using Microsoft.EntityFrameworkCore;
using PhoenixTheatre.DataInfrastructure;

namespace PhoenixTheatreAPI.Data
{
    public class PhoenixTheatreContext : DbContext
    {
        public PhoenixTheatreContext() { }
        public PhoenixTheatreContext(DbContextOptions<PhoenixTheatreContext> options) : base(options)
        {

        }

        public virtual DbSet<TheatreFilm> TheatreFilm => Set<TheatreFilm>();
        public virtual DbSet<FilmShowing> FilmShowings => Set<FilmShowing>();
        public virtual DbSet<CustomerOrder> Orders => Set<CustomerOrder>();
        public virtual DbSet<Customer> Customer => Set<Customer>();
        public virtual DbSet<Employee> Employee => Set<Employee>();
    }
}

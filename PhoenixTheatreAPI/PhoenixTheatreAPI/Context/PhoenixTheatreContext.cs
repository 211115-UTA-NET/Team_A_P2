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

        public virtual DbSet<Customer> Customer => Set<Customer>();
        public virtual DbSet<CustomerOrder> Orders => Set<CustomerOrder>();
        public virtual DbSet<Employee> Employee => Set<Employee>();
        public virtual DbSet<FilmShowings> FilmShowings => Set<FilmShowings>();
        public virtual DbSet<InvoiceLineItem> InvoiceLineItem => Set<InvoiceLineItem>();
        public virtual DbSet<Theatre> Theatre => Set<Theatre>();
        public virtual DbSet<TheatreFilms> TheatreFilms => Set<TheatreFilms>();
        public virtual DbSet<Tickets> Tickets => Set<Tickets>();
    }
}

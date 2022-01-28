using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PhoenixTheatre.DataInfrastructure
{
    public partial class Team_A_P2Context : DbContext
    {
        public Team_A_P2Context()
        {
        }

        public Team_A_P2Context(DbContextOptions<Team_A_P2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerOrder> CustomerOrders { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<FilmShowing> FilmShowings { get; set; } = null!;
        public virtual DbSet<InvoiceLineItem> InvoiceLineItems { get; set; } = null!;
        public virtual DbSet<Theatre> Theatres { get; set; } = null!;
        public virtual DbSet<TheatreFilm> TheatreFilms { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.HasIndex(e => e.Username, "UQ__Customer__536C85E4C3685079")
                    .IsUnique();

                entity.Property(e => e.CustomerId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.UserPassword).HasMaxLength(200);

                entity.Property(e => e.Username).HasMaxLength(100);
            });

            modelBuilder.Entity<CustomerOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Customer__C3905BCFFB8A387A");

                entity.ToTable("CustomerOrder");

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CustomerO__Custo__5C02A283");

                entity.HasOne(d => d.Theatre)
                    .WithMany(p => p.CustomerOrders)
                    .HasForeignKey(d => d.TheatreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CustomerO__Theat__5CF6C6BC");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.HasIndex(e => e.Username, "UQ__Employee__536C85E4D1668D10")
                    .IsUnique();

                entity.Property(e => e.EmployeeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.IsManager).HasMaxLength(3);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.UserPassword).HasMaxLength(200);

                entity.Property(e => e.Username).HasMaxLength(100);

                entity.HasOne(d => d.Theatre)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.TheatreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employee__Theatr__592635D8");
            });

            modelBuilder.Entity<FilmShowing>(entity =>
            {
                entity.HasKey(e => e.FilmShowingsId)
                    .HasName("PK__FilmShow__627F02E2C0853EA8");

                entity.Property(e => e.ShowDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Showtime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.FilmShowings)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmShowi__FilmI__6C390A4C");

                entity.HasOne(d => d.Theatre)
                    .WithMany(p => p.FilmShowings)
                    .HasForeignKey(d => d.TheatreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FilmShowi__Theat__6B44E613");
            });

            modelBuilder.Entity<InvoiceLineItem>(entity =>
            {
                entity.HasKey(e => e.InvoiceId)
                    .HasName("PK__InvoiceL__D796AAB52CC8FDFB");

                entity.ToTable("InvoiceLineItem");

                entity.Property(e => e.TicketType).HasMaxLength(100);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InvoiceLi__Order__61BB7BD9");

                entity.HasOne(d => d.TicketTypeNavigation)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.TicketType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InvoiceLi__Ticke__62AFA012");
            });

            modelBuilder.Entity<Theatre>(entity =>
            {
                entity.ToTable("Theatre");

                entity.Property(e => e.TheatreLocation).HasMaxLength(100);
            });

            modelBuilder.Entity<TheatreFilm>(entity =>
            {
                entity.HasKey(e => e.FilmId)
                    .HasName("PK__TheatreF__6D1D217CFC68B08B");

                entity.Property(e => e.FilmDescription).HasMaxLength(300);

                entity.Property(e => e.FilmName).HasMaxLength(200);

                entity.Property(e => e.FilmRating).HasMaxLength(5);

                entity.Property(e => e.Genre).HasMaxLength(100);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => e.TicketType)
                    .HasName("PK__Tickets__9A2958D399A82912");

                entity.Property(e => e.TicketType).HasMaxLength(100);

                entity.Property(e => e.TicketPrice).HasColumnType("money");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

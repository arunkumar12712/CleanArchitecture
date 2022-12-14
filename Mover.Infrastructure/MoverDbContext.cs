using Microsoft.EntityFrameworkCore;
using Mover.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mover.Infrastructure
{
    public class MoverDbContext :DbContext
    {
        public MoverDbContext(DbContextOptions<MoverDbContext> options):base(options) 
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One to Many (Member to Rental)
            modelBuilder.Entity<Member>()
                 .HasOne<Rental>(s => s.Rental)
                 .WithMany(r => r.Members)
                 .HasForeignKey(s => s.RentalId);

            // Many to many (Rental to Movie)

            modelBuilder.Entity<MovieRental>()
                .HasKey(g => new { g.RentalId, g.MovieId});

            // Handle decimal to avoid precision loss

            modelBuilder.Entity<Rental>()
                .Property(p => p.TotalCost)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Movie>()
               .Property(p => p.RentalCost)
               .HasColumnType("decimal(18,2)");

        }
        public DbSet<User> Users { get; set; }  
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MovieRental> MovieRentals { get; set; }
    }
}

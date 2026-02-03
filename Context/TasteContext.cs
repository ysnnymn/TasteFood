using Microsoft.EntityFrameworkCore;
using TasteFoodIt.Entities;

namespace TasteFoodIt.Context;

public class TasteContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=localhost;Initial Catalog=TasteFoodItDb;User ID=SA;Password=Yasinyaman.43;Encrypt=False;TrustServerCertificate=True"
        );
    }

    public DbSet<About> Abouts { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Chef> Chefs { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<OpenDayHour> OpenDayHours { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
}
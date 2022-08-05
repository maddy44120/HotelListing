using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
                    ShortName = "IND"
                },
                new Country
                {
                    Id = 2,
                    Name = "United States of America",
                    ShortName = "USA"
                },
                new Country
                {
                    Id = 3,
                    Name = "Australia",
                    ShortName = "AUS"
                }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sheraton Grand",
                    Address = "Pune",
                    CountryId = 1,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 2,
                    Name = "BloomingDel",
                    Address = "New Mexico",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Relax",
                    Address = "Kankavli",
                    CountryId = 1,
                    Rating = 4.0
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Lotus",
                    Address = "Brisbane",
                    CountryId = 3,
                    Rating = 4.8
                },
                new Hotel
                {
                    Id = 5,
                    Name = "eden Garden",
                    Address = "Detroit",
                    CountryId = 2,
                    Rating = 4.2
                }
                );
        }
    }
}

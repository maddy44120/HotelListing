using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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

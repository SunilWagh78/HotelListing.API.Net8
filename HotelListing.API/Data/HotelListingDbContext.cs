using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext: DbContext
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
                new Country { Id = 1, Name = "Jamaika", ShortName = "JM" },
                new Country { Id = 2, Name = "India", ShortName = "IN" },
                new Country { Id = 3, Name = "Bahamas", ShortName = "BS" }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { Id = 1, Name = "Sandals Recort and Spa", Address = "Negril", CountryId=1,Rating=4.5 },
                new Hotel { Id = 2, Name = "Comfort Suits", Address = "George Town", CountryId = 3, Rating = 4.3 },
                new Hotel { Id = 3, Name = "Grand Paldium", Address = "Nausua", CountryId = 2, Rating =4 }
                );
        }

    }
}

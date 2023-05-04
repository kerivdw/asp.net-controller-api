using asp.net_controller_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace asp.net_controller_api.DbContexts
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Address> Address { get; set; } = null!;

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                FirstName = "Joe",
                LastName = "Blogg",
                DateOfBirth = new DateTime(1954, 1, 1),
            },
            new User()
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Blogg",
                DateOfBirth = new DateTime(1956, 1, 1),
            });
            modelBuilder.Entity<Address>().HasData(new Address()
            {
                Id = 1,
                Addressline1 = "1 Main Street",
                Addressline2 = "This building",
                Suburb = "Evergreen",
                City = "Wellington",
                Country = "New Zealand",
                PostCode = "5010",
                userId = 1,
            },
            new Address()
            {
                Id = 2,
                Addressline1 = "2 Main Street",
                Addressline2 = "This building",
                Suburb = "EverBlue",
                City = "Napier",
                Country = "New Zealand",
                PostCode = "7000",
                userId = 2,
            });
            base.OnModelCreating(modelBuilder);
        }

    }
}
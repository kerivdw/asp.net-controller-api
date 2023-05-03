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
                FirstName = "Keri",
                LastName = "van der Westhuizen",
                DateofBirth = new DateTime(1977, 1, 1),
                Address_Id = 1,
            },
            new User()
            {
                Id = 2,
                FirstName = "Grant",
                LastName = "van der Westhuizen",
                DateofBirth = new DateTime(1977, 1, 1),
                Address_Id = 1,
            }) ;
            modelBuilder.Entity<Address>().HasData(new Address()
            {
                Id = 1,
                Addressline1 = "1 Main Street",
                Addressline2 = "This building",
                Suburb = "Avalon",
                City = "Lower Hutt",
                Country = "New Zealand",
                PostCode = "5010",
            });
            base.OnModelCreating(modelBuilder);
        }

    }
}
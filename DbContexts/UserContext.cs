using asp.net_controller_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace asp.net_controller_api.DbContexts
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Address { get; set; }

        public UserContext(DbContextOptions<UserContext> options) : base(options) 
        {
            
        }
    }
}

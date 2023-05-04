using asp.net_controller_api.DbContexts;
using asp.net_controller_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace asp.net_controller_api.Services
{
    public class UserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context, ILogger<UserRepository> logger) 
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Entities.User>?> GetUsersAsync() 
        {
            var users = await _context.Users.Include(user => user.Address).ToListAsync();
            return users; 
        }

        public async Task<Entities.User?> GetUserAsync(int id) 
        {
           var user =  await _context.Users.Include(user => user.Address).Where(user => user.Id == id).FirstOrDefaultAsync();
           return user;
        }

        public async Task<Entities.User?> CreateUserAsync(User user)
        {     
            var userEntity = await _context.AddAsync<User>(user);
            await _context.SaveChangesAsync();

            return userEntity.Entity;
        }
    }
}

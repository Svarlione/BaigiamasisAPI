using BaigiamasisAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BaigiamasisAPI.Data
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
    }
}

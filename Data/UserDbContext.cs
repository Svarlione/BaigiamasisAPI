using BaigiamasisAPI.Models;
using Google.Apis.Admin.Directory.directory_v1.Data;
using Microsoft.EntityFrameworkCore;
using User = BaigiamasisAPI.Models.User;

namespace BaigiamasisAPI.Data
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserAdress> UserAdress { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<LoginInfo> LoginInfo { get; set; }


        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
    }
}

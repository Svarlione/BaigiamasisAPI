using BaigiamasisAPI.Models;
using Google.Apis.Admin.Directory.directory_v1.Data;
using User = BaigiamasisAPI.Models.User;

namespace BaigiamasisAPI.Data
{
    public class DbRepository : IDbRepository
    {
        private readonly UserDbContext _userDbContext;

        public DbRepository(UserDbContext context)
        {
            _userDbContext = context;
        }

        public long Create(User user)
        {
            _userDbContext.Users.Add(user);
            _userDbContext.SaveChanges();
            return user.Id;
        }

        public void UpdateUser(User user)
        {
            _userDbContext.Users.Update(user);
            _userDbContext.SaveChanges();
        }

        public void DeleteUser(long userId)
        {
            var deleting = _userDbContext.Users.Find(userId);

            if (deleting != null)
            {
                _userDbContext.Users.Remove(deleting);
                _userDbContext.SaveChanges();
            }
        }

        public User GetUserByUserId(long userId)
        {
            return _userDbContext.Users.FirstOrDefault(x => x.Id == userId);
        }

        public void CreateAdress(UserAdress userAdress)
        {
            _userDbContext.UserAdress.Add(userAdress);
            _userDbContext.SaveChanges();
        }

        public void UpdateAdress(UserAdress userAdress)
        {
            _userDbContext.UserAdress.Update(userAdress);
            _userDbContext.SaveChanges();
        }

    }
}

using BaigiamasisAPI.Models;

namespace BaigiamasisAPI.Data
{
    public interface IDbRepository
    {
        long Create(User user);
        void CreateAdress(UserAdress userAdress);
        void DeleteUser(long userId);
        User GetUserByUserId(long userId);
        void UpdateAdress(UserAdress userAdress);
        void UpdateUser(User user);
    }
}
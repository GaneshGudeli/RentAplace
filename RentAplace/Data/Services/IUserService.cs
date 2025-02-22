using RentAplace.Data.Entities;

namespace RentAplace.Data.Services
{
    public interface IUserService
    {
        User GetUserById(int userId);

        void UpdateUser(User user);

        void DeleteUser(int id);
    }
}

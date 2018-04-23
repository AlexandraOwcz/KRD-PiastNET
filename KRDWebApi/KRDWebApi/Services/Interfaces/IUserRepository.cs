using KRDWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KRDWebApi
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        String DeleteUser(int id);
        void AddUser(User user);
        void EditUser(int id, User u);
    }
}

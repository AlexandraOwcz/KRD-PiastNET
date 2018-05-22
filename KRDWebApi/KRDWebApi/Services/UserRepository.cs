using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KRDWebApi.Models;

namespace KRDWebApi
{
    public class UserRepository : IUserRepository
    {
        //private static 
        private static List<User> _users = new List<User>()
        {
             new User()
                {
                    Id = 1,
                    Name = "Jasia",
                    Surname = "Kowalska",
                    Street = "Kwiatowa 6",
                    Gender = "K",
                    Country = "Poland"
                },
                new User()
                {
                    Id = 2,
                    Name = "Zbigniew",
                    Surname = "Boniek",
                    Street = "Pilsudskiego 10",
                    Gender = "M",
                    Country = "Poland"
                },
                new User()
                {
                    Id = 3,
                    Name = "Elzbieta",
                    Surname = "Krzak",
                    Street = "Lipowa 6",
                    Gender = "K",
                    Country = "Poland"
                }
        };

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public string DeleteUser(int id)
        {
            User user = _users.Where(x => x.Id == id).Single<User>();
            if (user != null)
            {
                _users.Remove(user);
                return "Record has successfully Deleted";
            }
            return "Sth went wrong!";
        }

        public void EditUser(int id, User u)
        {
            _users.ElementAt(id).Name = u.Name;
            _users.ElementAt(id).Surname = u.Surname;
            _users.ElementAt(id).Street = u.Street;
            _users.ElementAt(id).Gender = u.Gender;
            _users.ElementAt(id).Country = u.Country;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        public User GetUserById(int id)
        {
            var user = _users.FirstOrDefault(i => i.Id == id);
            return user;
        }
    }
}

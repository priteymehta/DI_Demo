using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Domain.Model;

namespace DI.Domain.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        User ReadUserDetails(int id);
    }
}

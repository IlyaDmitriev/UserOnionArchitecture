using System;
using UserDomain.Models;

namespace UserInfrastructure.Interfaces
{
    public interface IContext
    {
        bool CheckExistUser(User user);
        void AddUser(User user);
    }
}

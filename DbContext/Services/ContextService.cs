using System.Collections.Generic;
using UserDomain.Models;
using UserInfrastructure.Interfaces;

namespace DbContext.Services
{
    public class ContextService : IContext
    {
        private static List<string> UsersList;
        public ContextService()
        {
            UsersList = new List<string>();
        }
        public void AddUser(User user)
        {
            UsersList.Add(user.Login);
        }

        public bool CheckExistUser(User user)
        {
            return UsersList.Contains(user.Login);
        }
    }
}

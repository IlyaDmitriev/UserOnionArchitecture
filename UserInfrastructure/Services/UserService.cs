using System;
using System.Collections.Generic;
using System.Text;
using UserDomain.Interfaces;
using UserDomain.Models;
using UserInfrastructure.Interfaces;

namespace UserInfrastructure.Services
{
    public class UserService : IUserService
    {
        private IContext _context;
        public UserService(IContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            if (!_context.CheckExistUser(user))
            {
                _context.AddUser(user);
            }
            else
            {
                throw new Exception("Такой пользователь уже существует.");
            }
        }
    }
}

using System;

namespace UserDomain.Models
{
    public class User
    {
        public User(string login)
        {
            if (!string.IsNullOrWhiteSpace(login))
            {
                Login = login;
            }
            else
            {
                throw new Exception("Логин должен быть не пустым.");
            }
            
        }

        public string Login { get; set; }
    }
}

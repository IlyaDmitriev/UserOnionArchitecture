using UserDomain.Interfaces;
using UserApplication.Interfaces;
using UserApplication.Models;
using UserDomain.Models;

namespace UserApplication.Services
{
    public class UserAddCommandService : IUserAddCommand
    {
        private readonly IUserService _noteRepository;

        public UserAddCommandService(IUserService noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public void AddUser(DTOUser dtoUser)
        {
            _noteRepository.Add(new User(dtoUser.Login));
        }
    }
}

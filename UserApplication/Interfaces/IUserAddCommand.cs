using UserApplication.Models;

namespace UserApplication.Interfaces
{
    public interface IUserAddCommand
    {
        void AddUser(DTOUser dtoUser);
    }
}

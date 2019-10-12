using ConsoleUI.Extensions;
using ConsoleUI.Interfaces;
using ConsoleUI.Models.Enums;
using System;
using UserApplication.Interfaces;
using UserApplication.Models;

namespace ConsoleUI.Services
{
    public class UserConsoleService : IUserConsoleService
    {
        private readonly IConsoleProvider _console;
        private readonly IUserAddCommand _userAddCommand;

        public UserConsoleService(IConsoleProvider console, IUserAddCommand userAddCommand)
        {
            _console = console ?? throw new ArgumentNullException(nameof(console));
            _userAddCommand = userAddCommand ?? throw new ArgumentNullException(nameof(userAddCommand));
        }

        public void Handle(string strCommand)
        {
            if (!Enum.TryParse(strCommand.Capitalize(), out Command command))
            {
                _console.WriteLine($"Wrong input! Press any key to proceed...");
                _console.ReadKey();
                return;
            }

            Handle(command);
        }

        public void Handle(Command command)
        {
            switch (command)
            {
                case Command.Add:
                    AddNote();

                    break;
            }
        }

        private void AddNote()
        {
            _console.WriteLine("Введите уникальное имя пользователя.");
            _console.Write("> ");
            var login = _console.ReadLine();


            _userAddCommand.AddUser(new DTOUser { Login = login });
            _console.WriteLine("Пользователь создан");
        }
    }
}

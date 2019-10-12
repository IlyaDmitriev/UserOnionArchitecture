using ConsoleUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class UserApp
    {
        private readonly IUserConsoleService _userService;
        private readonly IConsoleProvider _console;


        public UserApp(IUserConsoleService userService, IConsoleProvider console)
        {
            _userService = userService;
            _console = console ?? throw new ArgumentNullException(nameof(console));
        }
        public void Run()
        {
            while (true)
            {
                _userService.Handle("Add");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.Interfaces
{
    public interface IConsoleProvider
    {
        void WriteLine(string input);
        void WriteLine();
        void Write(string input);
        string ReadLine();
        ConsoleKeyInfo ReadKey();
        void Clear();
        void SetTitle(string title);
    }
}

using ConsoleUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.Services
{
    public class ConsoleProvider : IConsoleProvider
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public void Write(string input)
        {
            Console.Write(input);
        }

        public void WriteLine(string input)
        {
            Console.WriteLine(input);
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void SetTitle(string title)
        {
            Console.Title = title;
        }
    }
}

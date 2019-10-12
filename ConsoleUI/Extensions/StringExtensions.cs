using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.Extensions
{
    public static class StringExtensions
    {
        public static string Capitalize(this string text)
        {
            return text.Trim().Substring(0, 1).ToUpper() + text.Trim().Substring(1).ToLower();
        }
    }
}

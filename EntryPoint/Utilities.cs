
using System;

namespace EntryPoint
{
    static class Utilities
    {
        public static void ColorFulWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

using System;

namespace PointAndLines
{
    static class Utilites
    {
        public static void ColorFullWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
using System;

namespace WarriorWars
{
    static class Tools
    {
        public static void ColorfulWriteLine(string text, ConsoleColor color)
        {
            System.Console.ForegroundColor = color;
            System.Console.WriteLine(text);
            System.Console.ResetColor();
        }
    }
}
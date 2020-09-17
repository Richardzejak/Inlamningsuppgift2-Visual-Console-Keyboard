using System;
using System.Collections.Generic;
using System.Text;

namespace Inlamningsuppgift_2
{
    public class KeyboardPress
    {
        public void ChangeTextColor(string letter, int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.SetCursorPosition(x, y);
            Console.Write(letter);
            Console.Beep(100, 150);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(x, y);
            Console.Write(letter);
            Console.SetCursorPosition(0, 0);
        }
    }
}

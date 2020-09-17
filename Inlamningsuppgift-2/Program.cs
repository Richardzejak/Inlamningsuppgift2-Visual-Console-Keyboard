using Inlamningsuppgift_2;
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        Console.SetWindowSize(150, 20); // Resize console window

        Keyboard keyboard = new Keyboard(); //creating keyboard object from class and prints it from the constructor

        //ConsoleKeyInfo key = Console.ReadKey(); // creating key variable thats equal to key pressed
        int x = 0;
        int y = 0;
        char letter = ' ';

        Console.WriteLine("");
        while (true) // infinite loop
        {
            ConsoleKeyInfo key = Console.ReadKey(); // creating key variable thats equal to key pressed
            Console.SetCursorPosition(x, y);
            Console.Write(letter);

            Console.ForegroundColor = ConsoleColor.Green;


            if (key.Key == ConsoleKey.W)
            {
                x = 24; y = 9;
                letter = 'W';
                Console.SetCursorPosition(x,y);
                Console.Write(letter);
                Console.Beep(100, 150);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(x, y);
                Console.Write(letter);
            }
            if (key.Key == ConsoleKey.A)
            {
                x = 19; y = 11;
                letter = 'A';
                Console.SetCursorPosition(x, y);
                Console.Write(letter);
                Console.Beep(150, 150);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(x, y);
                Console.Write(letter);
            }
            if (key.Key == ConsoleKey.S)
            {
                x = 25; y = 11;
                letter = 'S';
                Console.SetCursorPosition(x, y);
                Console.Write(letter);
                Console.Beep(200, 150);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(x, y);
                Console.Write(letter);
            }
            if (key.Key == ConsoleKey.D)
            {
                x = 31; y = 11;
                letter = 'D';
                Console.SetCursorPosition(x, y);
                Console.Write(letter);
                Console.Beep(250, 150);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(x, y);
                Console.Write(letter);
            }
            Console.SetCursorPosition(x, y);
        }
    }
}

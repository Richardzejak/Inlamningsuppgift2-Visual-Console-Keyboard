using Inlamningsuppgift_2;
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        Console.SetWindowSize(150, 20); // Resize console window

        Keyboard keyboard = new Keyboard(); //creating keyboard object from class and prints it from the constructor

        ConsoleKeyInfo key = Console.ReadKey(); // creating key variable thats equal to key pressed


        Console.WriteLine("");
        while (true) // infinite loop
        {
            Console.ForegroundColor = ConsoleColor.Green;

            if (key.Key == ConsoleKey.W)
            {
                Console.SetCursorPosition(24,9);
                Console.Write('W');
            }
            if (key.Key == ConsoleKey.A)
            {

            }
            if (key.Key == ConsoleKey.S)
            {

            }
            if (key.Key == ConsoleKey.D)
            {

            }
            if (key.Key == ConsoleKey.E)
            {

            }
            Console.ResetColor();
        }
    }
}

using Inlamningsuppgift_2;
using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Console.SetWindowSize(150, 20); // Resize console window

        Keyboard keyboard = new Keyboard(); //creating keyboard object from class and prints it from the constructor

        KeyboardPress keyboardPress = new KeyboardPress();

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

            switch (key.Key)
            {
                case (ConsoleKey.W):
                    keyboardPress.ChangeTextColor("W", 24, 9);
                    break;
                case (ConsoleKey.A):
                    keyboardPress.ChangeTextColor("A", 19, 11);
                    break;
                case (ConsoleKey.S):
                    keyboardPress.ChangeTextColor("S", 25, 11);
                    break;
                case (ConsoleKey.D):
                    keyboardPress.ChangeTextColor("D", 31, 11);
                    break;
            }
        }
    }
}

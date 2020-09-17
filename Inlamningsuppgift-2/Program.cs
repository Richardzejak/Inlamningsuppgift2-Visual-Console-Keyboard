using Inlamningsuppgift_2;
using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Console.SetWindowSize(150, 20); // Resize console window

        //ConsoleKeyInfo key = Console.ReadKey(); // creating key variable thats equal to key pressed
        int x;
        int y;
        char letter;

        Console.WriteLine(Keyboard.keyboardString); //draws keyboard on construction


        Console.WriteLine("");
        while (true) // infinite loop
        {
            letter = ' ';
            x = 0;
            y = 0;
            Console.SetCursorPosition(x, y);
            Console.Write(letter);

            CheckWhichKey.CheckWhichKeyMethod();
        }
    }
}

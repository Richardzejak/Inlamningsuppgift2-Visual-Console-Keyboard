using System;
using System.Collections.Generic;
using System.Text;

namespace Inlamningsuppgift_2
{
    public class CheckWhichKey
    {
        public void CheckWhichKeyMethod()
        { 
        KeyboardPress keyboardPress = new KeyboardPress();
        ConsoleKeyInfo key = Console.ReadKey(); // creating key variable thats equal to key pressed

            switch (key.Key) // checks key press and sends key and coords to keyboardpress class
         {// 106 buttons
            case (ConsoleKey.W):
                keyboardPress.ChangeTextColor("W", 24, 9, 100);
                break;
            case (ConsoleKey.A):
                 keyboardPress.ChangeTextColor("A", 19, 11, 150);
                 break;
            case (ConsoleKey.S):
                 keyboardPress.ChangeTextColor("S", 25, 11, 200);
                 break;
            case (ConsoleKey.D):
                 keyboardPress.ChangeTextColor("D", 31, 11, 250);
                 break;
            }
        }
    }
}

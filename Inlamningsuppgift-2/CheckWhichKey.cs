using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Inlamningsuppgift_2
{
    public class CheckWhichKey
    {
        public static void CheckWhichKeyMethod()
        {
            ConsoleKeyInfo key = Console.ReadKey(); // creating key variable thats equal to key pressed
            Thread.Sleep(200);
            ConsoleKeyInfo second_key;

            if (Console.KeyAvailable && key.Key == ConsoleKey.Escape)
            {
                second_key = Console.ReadKey();
                if (second_key.Key == ConsoleKey.Q)
                {
                    Console.Clear();
                    MainMenu.MainMenuChoice();
                }
            }

            if (Console.KeyAvailable && key.Key == ConsoleKey.Q)
            {
                second_key = Console.ReadKey();
                if (second_key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    MainMenu.MainMenuChoice();
                }
            }

            switch (key.Key) // checks key press and sends key and coords to KeyboardPress class
            {// 106 buttons
                case (ConsoleKey.Escape):
                    KeyboardPress.ChangeTextColor("Esc", 10, 4, 100);
                    break;
                case (ConsoleKey.F1):
                    KeyboardPress.ChangeTextColor("F1", 18, 4, 150);
                    break;
                case (ConsoleKey.F2):
                    KeyboardPress.ChangeTextColor("F2", 24, 4, 200);
                    break;
                case (ConsoleKey.F3):
                    KeyboardPress.ChangeTextColor("F3", 30, 4, 250);
                    break;
                case (ConsoleKey.F4):
                    KeyboardPress.ChangeTextColor("F4", 36, 4, 100);
                    break;
                case (ConsoleKey.F5):
                    KeyboardPress.ChangeTextColor("F5", 45, 4, 150);
                    break;
                case (ConsoleKey.F6):
                    KeyboardPress.ChangeTextColor("F6", 50, 4, 200);
                    break;
                case (ConsoleKey.F7):
                    KeyboardPress.ChangeTextColor("F7", 56, 4, 250);
                    break;
                case (ConsoleKey.F8):
                    KeyboardPress.ChangeTextColor("F8", 62, 4, 100);
                    break;
                case (ConsoleKey.F9):
                    KeyboardPress.ChangeTextColor("F9", 70, 4, 150);
                    break;
                case (ConsoleKey.F10):
                    KeyboardPress.ChangeTextColor("F10", 76, 4, 200);
                    break;
                case (ConsoleKey.F11):
                    KeyboardPress.ChangeTextColor("F11", 82, 4, 250);
                    break;
                case (ConsoleKey.F12):
                    KeyboardPress.ChangeTextColor("F12", 88, 4, 100);
                    break;
                case (ConsoleKey.PrintScreen):
                    KeyboardPress.ChangeTextColor("Ptrsc", 96, 4, 150);
                    break;
                case (ConsoleKey.Pause):
                    KeyboardPress.ChangeTextColor("Pause", 107, 4, 250);
                    break;
                case (ConsoleKey.Oem5):
                    KeyboardPress.ChangeTextColor("½", 11, 7, 100);
                    break;
                case (ConsoleKey.D1):
                    KeyboardPress.ChangeTextColor("1", 16, 7, 150);
                    break;
                case (ConsoleKey.D2):
                    KeyboardPress.ChangeTextColor("2", 22, 7, 200);
                    break;
                case (ConsoleKey.D3):
                    KeyboardPress.ChangeTextColor("3", 28, 7, 250);
                    break;
                case (ConsoleKey.D4):
                    KeyboardPress.ChangeTextColor("4", 34, 7, 100);
                    break;
                case (ConsoleKey.D5):
                    KeyboardPress.ChangeTextColor("5", 40, 7, 150);
                    break;
                case (ConsoleKey.D6):
                    KeyboardPress.ChangeTextColor("6", 46, 7, 200);
                    break;
                case (ConsoleKey.D7):
                    KeyboardPress.ChangeTextColor("7", 52, 7, 250);
                    break;
                case (ConsoleKey.D8):
                    KeyboardPress.ChangeTextColor("8", 58, 7, 100);
                    break;
                case (ConsoleKey.D9):
                    KeyboardPress.ChangeTextColor("9", 64, 7, 150);
                    break;
                case (ConsoleKey.D0):
                    KeyboardPress.ChangeTextColor("0", 70, 7, 200);
                    break;
                case (ConsoleKey.OemPlus):
                    KeyboardPress.ChangeTextColor("+", 76, 7, 250);
                    break;
                case (ConsoleKey.Oem4):
                    KeyboardPress.ChangeTextColor("´", 80, 7, 250);
                    break;
                case (ConsoleKey.Backspace):
                    KeyboardPress.ChangeTextColor("<---", 86, 7, 150);
                    break;
                case (ConsoleKey.Insert):
                    KeyboardPress.ChangeTextColor("Ins", 97, 7, 250);
                    break;
                case (ConsoleKey.Home):
                    KeyboardPress.ChangeTextColor("Home", 102, 7, 100);
                    break;
                case (ConsoleKey.PageUp):
                    KeyboardPress.ChangeTextColor("PgUp", 108, 7, 150);
                    break;
                case (ConsoleKey.Tab):
                    KeyboardPress.ChangeTextColor("->", 11, 9, 200);
                    KeyboardPress.ChangeTextColor("<-", 11, 10, 200);
                    break;
                case (ConsoleKey.Q):
                    KeyboardPress.ChangeTextColor("Q", 18, 9, 250);
                    break;
                case (ConsoleKey.W):
                    KeyboardPress.ChangeTextColor("W", 24, 9, 100);
                    break;
                case (ConsoleKey.E):
                    KeyboardPress.ChangeTextColor("E", 30, 9, 150);
                    break;
                case (ConsoleKey.R):
                    KeyboardPress.ChangeTextColor("R", 36, 9, 200);
                    break;
                case (ConsoleKey.T):
                    KeyboardPress.ChangeTextColor("T", 42, 9, 250);
                    break;
                case (ConsoleKey.Y):
                    KeyboardPress.ChangeTextColor("Y", 48, 9, 100);
                    break;
                case (ConsoleKey.U):
                    KeyboardPress.ChangeTextColor("U", 54, 9, 150);
                    break;
                case (ConsoleKey.I):
                    KeyboardPress.ChangeTextColor("I", 60, 9, 200);
                    break;
                case (ConsoleKey.O):
                    KeyboardPress.ChangeTextColor("O", 66, 9, 250);
                    break;
                case (ConsoleKey.P):
                    KeyboardPress.ChangeTextColor("P", 72, 9, 250);
                    break;
                case (ConsoleKey.Oem6):
                    KeyboardPress.ChangeTextColor("Å", 78, 9, 100);
                    break;
                case (ConsoleKey.Oem1):
                    KeyboardPress.ChangeTextColor("¨", 84, 9, 150);
                    break;
                case (ConsoleKey.Enter):
                    KeyboardPress.ChangeTextColor("<--/", 88, 10, 200);
                    break;
                case (ConsoleKey.Delete):
                    KeyboardPress.ChangeTextColor("Del", 97, 9, 250);
                    break;
                case (ConsoleKey.End):
                    KeyboardPress.ChangeTextColor("End", 103, 9, 100);
                    break;
                case (ConsoleKey.PageDown):
                    KeyboardPress.ChangeTextColor("PgDwn", 108, 9, 150);
                    break;
                case (ConsoleKey.A):
                    KeyboardPress.ChangeTextColor("A", 19, 11, 250);
                    break;
                case (ConsoleKey.S):
                    KeyboardPress.ChangeTextColor("S", 25, 11, 100);
                    break;
                case (ConsoleKey.D):
                    KeyboardPress.ChangeTextColor("D", 31, 11, 150);
                    break;
                case (ConsoleKey.F):
                    KeyboardPress.ChangeTextColor("F", 37, 11, 200);
                    break;
                case (ConsoleKey.G):
                    KeyboardPress.ChangeTextColor("G", 43, 11, 250);
                    break;
                case (ConsoleKey.H):
                    KeyboardPress.ChangeTextColor("H", 49, 11, 100);
                    break;
                case (ConsoleKey.J):
                    KeyboardPress.ChangeTextColor("J", 55, 11, 150);
                    break;
                case (ConsoleKey.K):
                    KeyboardPress.ChangeTextColor("K", 61, 11, 200);
                    break;
                case (ConsoleKey.L):
                    KeyboardPress.ChangeTextColor("L", 67, 11, 250);
                    break;
                case (ConsoleKey.Oem3):
                    KeyboardPress.ChangeTextColor("Ö", 73, 11, 250);
                    break;
                case (ConsoleKey.Oem7):
                    KeyboardPress.ChangeTextColor("Ä", 79, 11, 100);
                    break;
                case (ConsoleKey.Oem2):
                    KeyboardPress.ChangeTextColor("'", 85, 11, 150);
                    break;
                case (ConsoleKey.Oem102):
                    KeyboardPress.ChangeTextColor("<", 18, 13, 150);
                    break;
                case (ConsoleKey.Z):
                    KeyboardPress.ChangeTextColor("Z", 24, 13, 250);
                    break;
                case (ConsoleKey.X):
                    KeyboardPress.ChangeTextColor("X", 30, 13, 250);
                    break;
                case (ConsoleKey.C):
                    KeyboardPress.ChangeTextColor("C", 36, 13, 100);
                    break;
                case (ConsoleKey.V):
                    KeyboardPress.ChangeTextColor("V", 42, 13, 150);
                    break;
                case (ConsoleKey.B):
                    KeyboardPress.ChangeTextColor("B", 48, 13, 200);
                    break;
                case (ConsoleKey.N):
                    KeyboardPress.ChangeTextColor("N", 54, 13, 250);
                    break;
                case (ConsoleKey.M):
                    KeyboardPress.ChangeTextColor("M", 60, 13, 250);
                    break;
                case (ConsoleKey.OemComma):
                    KeyboardPress.ChangeTextColor(",", 66, 13, 100);
                    break;
                case (ConsoleKey.OemPeriod):
                    KeyboardPress.ChangeTextColor(".", 72, 13, 150);
                    break;
                case (ConsoleKey.OemMinus):
                    KeyboardPress.ChangeTextColor("-", 78, 13, 200);
                    break;
                case (ConsoleKey.LeftWindows):
                    KeyboardPress.ChangeTextColor("Win", 24, 15, 100);
                    break;
                case (ConsoleKey.Spacebar):
                    KeyboardPress.ChangeTextColor("_____________________________", 36, 15, 200);
                    break;
                case (ConsoleKey.RightWindows):
                    KeyboardPress.ChangeTextColor("Win", 81, 15, 250);
                    break;
                case (ConsoleKey.UpArrow):
                    KeyboardPress.ChangeTextColor("^", 104, 13, 150);
                    break;
                case (ConsoleKey.LeftArrow):
                    KeyboardPress.ChangeTextColor("<", 98, 15, 200);
                    break;
                case (ConsoleKey.DownArrow):
                    KeyboardPress.ChangeTextColor("\\_/", 103, 15, 250);
                    break;
                case (ConsoleKey.RightArrow):
                    KeyboardPress.ChangeTextColor(">", 110, 15, 150);
                    break;
                case (ConsoleKey.Divide):
                    KeyboardPress.ChangeTextColor("/", 124, 7, 200);
                    break;
                case (ConsoleKey.Multiply):
                    KeyboardPress.ChangeTextColor("*", 130, 7, 250);
                    break;
                case (ConsoleKey.Subtract):
                    KeyboardPress.ChangeTextColor("-", 136, 7, 150);
                    break;
                case (ConsoleKey.NumPad7):
                    KeyboardPress.ChangeTextColor("7", 118, 9, 150);
                    break;
                case (ConsoleKey.NumPad8):
                    KeyboardPress.ChangeTextColor("8", 124, 9, 200);
                    break;
                case (ConsoleKey.NumPad9):
                    KeyboardPress.ChangeTextColor("9", 130, 9, 250);
                    break;
                case (ConsoleKey.Add):
                    KeyboardPress.ChangeTextColor("+", 136, 10, 250);
                    break;
                case (ConsoleKey.NumPad4):
                    KeyboardPress.ChangeTextColor("4", 118, 11, 150);
                    break;
                case (ConsoleKey.NumPad5):
                    KeyboardPress.ChangeTextColor("5", 124, 11, 250);
                    break;
                case (ConsoleKey.NumPad6):
                    KeyboardPress.ChangeTextColor("6", 130, 11, 150);
                    break;
                case (ConsoleKey.NumPad1):
                    KeyboardPress.ChangeTextColor("1", 118, 13, 150);
                    break;
                case (ConsoleKey.NumPad2):
                    KeyboardPress.ChangeTextColor("2", 124, 13, 200);
                    break;
                case (ConsoleKey.NumPad3):
                    KeyboardPress.ChangeTextColor("3", 130, 13, 250);
                    break;
                case (ConsoleKey.NumPad0):
                    KeyboardPress.ChangeTextColor("0", 117, 15, 150);
                    break;
                case (ConsoleKey.Decimal):
                    KeyboardPress.ChangeTextColor("Del", 129, 15, 200);
                    break;
            }
        }
    }
}

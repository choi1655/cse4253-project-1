using System;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;

namespace CSE4253_Project1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter Something");

            var result = new List<char>();

            int verticalP = 0;
            int horizontalP = 0;

            while (true)
            {
                var input = Console.ReadKey(true);

                if (input.Modifiers.HasFlag(ConsoleModifiers.Control) && input.Key.HasFlag(ConsoleKey.Enter))
                {
                    break;
                }

                if (char.IsLetterOrDigit(input.KeyChar))
                {
                    if (verticalP == result.Count)
                    {
                        result.Insert(verticalP++, input.KeyChar);
                    }
                    else
                    {
                        result[verticalP] = input.KeyChar;
                    }

                }
                else if (input.Key == ConsoleKey.LeftArrow && verticalP > 0)
                { 
                    verticalP--;
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                }
                else if (input.Key == ConsoleKey.RightArrow && verticalP < int.MaxValue)
                {
                    verticalP++;
                    Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
                }
                else if (input.Key == ConsoleKey.UpArrow && horizontalP < int.MaxValue)
                {
                    horizontalP++;
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
                }
                else if (input.Key == ConsoleKey.DownArrow && horizontalP > 0)
                {
                    horizontalP--;
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                }



            }


        }
    }
}

using System;
using AppKit;

namespace CSE4253_Project1
{
    class MainClass
    {
        public static readonly int size = 1000;

        public static void Main(string[] args)
        {
            NSApplication.Init();

            // grab the text from the clipboard
            var text = NSPasteboard.GeneralPasteboard.GetStringForType("NSStringPboardType");

            var strings = text.Split(new char[] {' ', ',', '.', '?'});

            string[] tokens = new string[size];
            for (int i = 0; i < strings.Length; i++)
            {
                string value = strings[i].Trim();
                Console.WriteLine(value);
                if (String.IsNullOrWhiteSpace(value))
                {
                    continue;
                }
                tokens[i] = strings[i];
            }

            // sort array
            Array.Sort(tokens);

            Console.WriteLine("HEREHEREHEREHERHEREHRERHEREHERHERHEREHR\n\n\n\n\n");
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(tokens[i]);
            }

            Console.WriteLine("\n\n\n\n\nEND OF THE PROGRAM");
        }
    }
}

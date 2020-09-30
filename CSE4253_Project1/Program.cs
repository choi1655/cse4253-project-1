using System;
using System.Collections.Generic;
using System.Linq;
using AppKit;

namespace CSE4253_Project1
{
    class MainClass
    {
        public static readonly int size = 1000;

        public static void Main(string[] args)
        {
            NSApplication.Init();
            Console.Clear();

            // grab the text from the clipboard
            var text = NSPasteboard.GeneralPasteboard.GetStringForType("NSStringPboardType");

            var strings = text.Split(new char[] {' ', ',', '.', '?', ';', ':', '!'});

            // sort array
            Array.Sort(strings);
            string[] tokens = new string[size];
            for (int i = 0; i < strings.Length && i < size; i++)
            {
                string value = strings[i].Trim().ToLower();
                if (String.IsNullOrWhiteSpace(value))
                {
                    continue;
                }
                tokens[i] = value;
            }

            // set for duplicate check
            var set = new HashSet<string>(tokens);

            string[] result = set.ToArray();
            for (int i = 0; i < result.Length && i < size; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}

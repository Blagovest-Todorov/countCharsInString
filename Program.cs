using System;
using System.Collections.Generic;

namespace CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries); //read a string

            string newInput = string.Empty;

            for (int i = 0; i < inputStr.Length; i++ )
            {
                newInput += inputStr[i];
            }

            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (var item in newInput)
            {
                if (letters.ContainsKey(item))
                {
                    letters[item] += 1;
                }
                else
                {
                    letters.Add(item, 1);
                }
            }

            foreach (var element in letters)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}

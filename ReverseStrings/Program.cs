using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string inputReversed = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                
                Reverse(input);
            }
        }
        static void Reverse(string input)
        {
            List<char> inputInChars = new List<char>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                inputInChars.Add(input[i]);
            }
            StringBuilder inputReversed = new StringBuilder();
            foreach (var item in inputInChars)
            {
                inputReversed.Append(item);
            }
            Console.WriteLine(input + " = " + inputReversed.ToString());
        }
    }
}
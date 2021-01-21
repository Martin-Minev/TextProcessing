using System;
using System.Linq;
using System.Collections.Generic;


namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> digits = new List<char>();
            List<char> letters = new List<char>();
            List<char> others = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digits.Add(input[i]);

                }
                else if (char.IsLetter(input[i]))
                {
                    letters.Add(input[i]);
                }

                else
                {
                    others.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join("", digits));
            Console.WriteLine(string.Join("", letters));
            Console.WriteLine(string.Join("", others));
        }
    }
}

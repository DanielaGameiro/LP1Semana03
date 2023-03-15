using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            char inputChar;

            Console.WriteLine("Write a string: ");
            inputString = Console.ReadLine();

            Console.WriteLine("Write a char: ");
            inputChar = char.Parse(Console.ReadLine());

            foreach (char c in inputString)
            {
                if (c != inputChar)
                {
                    Console.Write(c);
                }
            }
            Console.WriteLine();
        }
    }
}


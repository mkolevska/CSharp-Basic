using System;

namespace SEDC.ExtraHomework.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
         

            while (true)
            {
                Console.WriteLine("Enter a character to check if its an alphabet");
                string input = Console.ReadLine();

                bool isValidChar = char.TryParse(input, out char parsedInput);

                if (!isValidChar)
                {
                    Console.WriteLine("enter valid character");
                    continue;
                }
                else
                {
                    IsAlphabet(parsedInput);
                    break;
                }
            }

        }

        static char IsAlphabet(char character)
        {
            if (Char.IsLetter(character))
            {
                if (Char.IsUpper(character))
                {
                    Console.WriteLine("Character is alphabet and its UPPERCASE");
                }
                else
                {
                    Console.WriteLine("Character is alphabet and its lowercase");
                }
            }
            else
            {
                Console.WriteLine("Character is not alphabet");
            }

            return character;
        }
    }
}

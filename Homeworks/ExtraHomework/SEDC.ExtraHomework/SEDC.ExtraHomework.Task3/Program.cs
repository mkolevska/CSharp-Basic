using System;

namespace SEDC.ExtraHomework.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 3:
            
            string name = "Marija 30.07.1998";

            int vowels = NumberOfVowels(name);
            int digits = NumberOfDigits(name);
            Console.WriteLine(vowels);
            Console.WriteLine(digits);
        }

        static int NumberOfVowels(string str)
        {
            int vowels = 0;

            string strToLower = str.ToLower();

            for(int i = 0; i < strToLower.Length; i++)
            {
                if(strToLower[i] == 'a' || strToLower[i] == 'e' || strToLower[i] == 'i' || strToLower[i] == 'o' || strToLower[i] == 'u')
                {
                    vowels++;
                }
            }

            return vowels;
        }

        static int NumberOfDigits(string str)
        {
            int digits = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if(Char.IsDigit(str[i]))
                {
                    digits++;
                }
            }
            return digits;
        }
    }
}

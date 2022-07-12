using System;

namespace SEDC.ExtraHomework.Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1:
            //Create a function to say whether a string is symmetric(a palindrome). For example, "RADAR" is a palindrome.

            Console.WriteLine("Enter word to check if is it a palindrome");
            string input = Console.ReadLine();

            string result = IsPalindrome(input);
            Console.WriteLine(result);
        }

        static string IsPalindrome(string word)
        {
            char[] wordArray = word.ToCharArray();

            Array.Reverse(wordArray);

            string reversedWord = new string(wordArray);

            if (word == reversedWord)
            {
                return $"The word {word} is symmetric (a palindrome)";
            } else
            {
                return $"The word {word} is not symmetric (a palindrome)";
            }
        }
    }
}

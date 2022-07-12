using System;

namespace SEDC.ExtraHomework.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 4:
           
            Console.WriteLine("Enter a sentence");
            string input = Console.ReadLine();

            string result = Capitalization(input);

            Console.WriteLine(result);
        }

        static string Capitalization(string str)
        {

            string[] strArray = new string[str.Length];

            for(int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                {
                    strArray[i] = str[i].ToString().ToLower();
                }
                else
                {
                    strArray[i] = str[i].ToString().ToUpper();
                }
            }

            return string.Join("", strArray);
        }
    }
}

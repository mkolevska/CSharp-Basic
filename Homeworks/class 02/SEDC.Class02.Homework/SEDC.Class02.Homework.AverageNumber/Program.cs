using System;

namespace SEDC.Class02.Homework.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

            
            Console.WriteLine("Average Number");

            Console.WriteLine("Enter the first number:");
            string num1 = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string num2 = Console.ReadLine();

            Console.WriteLine("Enter the third number:");
            string num3 = Console.ReadLine();

            Console.WriteLine("Enter the fourth number:");
            string num4 = Console.ReadLine();

            bool isValidNum1 = double.TryParse(num1, out double parsedNum1);
            bool isValidNum2 = double.TryParse(num2, out double parsedNum2);
            bool isValidNum3 = double.TryParse(num3, out double parsedNum3);
            bool isvalidNum4 = double.TryParse(num4, out double parsedNum4);

            if (isValidNum1 && isValidNum2 && isValidNum3 && isvalidNum4)
            {
                double average = (parsedNum1 + parsedNum2 + parsedNum3 + parsedNum4) / 4;
                Console.WriteLine("The average of the entered numbers is:" + average);
            }
            else
            {
                Console.WriteLine("Error! Enter valid numbers");
            }
        }
    }
}

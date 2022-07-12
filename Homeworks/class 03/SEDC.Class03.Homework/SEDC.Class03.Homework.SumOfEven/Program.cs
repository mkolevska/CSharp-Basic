using System;

namespace SEDC.Class03.Homework.SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======SUM OF EVEN======");

            //Task 1
            //Make a console application called SumOfEven. Inside it create an array of 6 integers.
            //Get numbers from the input, find and print the sum of the even numbers from the array:

            int[] numbers = new int[6];

            for (int i = 0; i < numbers.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine("Enter number: " + (i + 1));
                    string input = Console.ReadLine();
                    bool isValid = int.TryParse(input, out int number);

                    if (!isValid)
                    {
                        Console.WriteLine("invalid number");
                        continue;
                    }
                    else
                    {
                        numbers[i] = number;
                        break;
                    }
                }
            }

            int sumOfeven = 0;

            foreach(int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sumOfeven += num;
                }
            }

            Console.WriteLine("The sum of the even numbers is " + sumOfeven);
        }
    }
}

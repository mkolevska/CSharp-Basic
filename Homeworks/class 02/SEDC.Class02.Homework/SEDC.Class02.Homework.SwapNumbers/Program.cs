using System;

namespace SEDC.Class02.Homework.SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:

            //Test Data:
            //Input the First Number: 5
            //Input the Second Number: 8
            //Expected Output:
            //After Swapping:
            //First Number: 8
            //Second Number: 5

            Console.WriteLine("SWAP NUMBERS");

            Console.WriteLine("Enter number one:");
            string num1 = Console.ReadLine();

            Console.WriteLine("Enter number two:");
            string num2 = Console.ReadLine();

            bool isValidNum1 = int.TryParse(num1, out int parsedNum1);
            bool isValidNum2 = int.TryParse(num2, out int parsedNum2);

            if(isValidNum1 && isValidNum2)
            {
                Console.WriteLine("First entered number: " + parsedNum1);
                Console.WriteLine("Second entered number: " + parsedNum2);

                int temporaryNum = parsedNum1;
                parsedNum1 = parsedNum2;
                parsedNum2 = temporaryNum;

                Console.WriteLine("Swapped value of the first entered number: " + parsedNum1);
                Console.WriteLine("Swapped value of the second entered number: " + parsedNum2);

            } else
            {
                Console.WriteLine("Error! Enter valid numbers");
            }
        }
        }
    }


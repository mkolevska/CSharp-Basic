using System;

namespace SEDC.Class02.Homework.RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done( +, - , * , / ). Then it returns the result.

            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the Operation: +
            //Expected Output:
            //The result is: 25

            Console.WriteLine("Calculator");

            Console.WriteLine("Enter the first number:");
            string numberOne = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string numberTwo = Console.ReadLine();

            bool isValidInputOne = double.TryParse(numberOne, out double parsedNumberOne);
            bool isValidInputTwo = double.TryParse(numberTwo, out double parsedNumberTwo);

            double result = 0;

            if (isValidInputOne && isValidInputTwo)
            {
                Console.WriteLine("Enter the operation you want to execute: ( +, - , * , / )");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = parsedNumberOne + parsedNumberTwo;
                        Console.WriteLine("The sum of the two numbers is: " + result);
                        break;

                    case "-":
                        result = parsedNumberOne - parsedNumberTwo;
                        Console.WriteLine("The difference of the two numbers is: " + result);
                        break;

                    case "*":
                        result = parsedNumberOne * parsedNumberTwo;
                        Console.WriteLine("The multiplication of the two numbers is: " + result);
                        break;

                    case "/":
                        if (parsedNumberTwo == 0)
                        {
                            Console.WriteLine("Cant divide with zero");
                        }
                        else
                        {
                            result = parsedNumberOne / parsedNumberTwo;
                            Console.WriteLine("The division of the two numbers is: " + result);
                        }
                        break;

                    default:
                        Console.WriteLine("You entered invalid operation sign. Try again");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Error! You entered invalid numbers. Try again");
            }
        }
    }
}

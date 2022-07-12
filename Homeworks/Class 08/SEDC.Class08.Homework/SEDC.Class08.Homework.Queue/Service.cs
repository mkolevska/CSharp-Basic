using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class08.Homework.Queue
{
    public class Service
    {

        public void Main()
        {
            Queue<int> result = AddNumbers();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Here are your numbers:");
            foreach(int num in result)
            {
                Console.WriteLine(num);
            }
        }
        public Queue<int> AddNumbers()
        {
            Queue<int> addNumber = new Queue<int>();

            int number = validateNum();
            addNumber.Enqueue(number);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Do you want to enter another number? \n1. Y\n2. No");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine();
                    number = validateNum();
                    addNumber.Enqueue(number);
                    continue;
                }
                else if (input == "2")
                {
                    return addNumber;
                }
                else
                {
                    Console.WriteLine("Enter valid option");
                    continue;
                }

            }
        }
        private int validateNum()
        {
            while (true)
            {
                Console.WriteLine("Enter a number:");
                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out int number);

                if (!isValid)
                {
                    Console.WriteLine("Enter valid number");
                    continue;
                }
                else
                {
                    return number;
                }
            }
        }
    }
}

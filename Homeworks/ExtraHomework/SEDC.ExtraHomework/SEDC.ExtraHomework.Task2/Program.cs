using System;
using System.Linq;

namespace SEDC.ExtraHomework.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 2:
            
            int[] numArray = { 1, 2, 6, 7, 8, 9, 10, 12321, 5, 6, 7 };
            int result = GreatestValue(numArray);
            int result1 = GreatestValueWithLinq(numArray);

            Console.WriteLine($"The greatest value in the array is: {result}");
            Console.WriteLine($"The greatest value in the array using System.Linq is: {result1}");
        }

        static int GreatestValue(int[] array)
        {
            int max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        static int GreatestValueWithLinq(int[] array)
        {
            int maxValue = array.Max();
            return maxValue;
        }
    }
}

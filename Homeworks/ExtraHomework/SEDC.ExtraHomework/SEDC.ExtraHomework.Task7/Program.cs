using System;

namespace SEDC.ExtraHomework.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 7:
           
            double result = Exponent(5, 3);
            Console.WriteLine(result);
        }

        static double Exponent (double numX, double numY)
        {
            double result = Math.Pow(numX, numY);
            return result;
        }
    }
}

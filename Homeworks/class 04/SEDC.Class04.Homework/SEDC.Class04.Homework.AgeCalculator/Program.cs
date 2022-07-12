using System;

namespace SEDC.Class04.Homework.AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Age Calculator =====");

            //Task
          
            while (true)
            {

                Console.WriteLine("Enter your birthdate in this format: dd/MM/YYYY");
                string input = Console.ReadLine();

                bool isValidDate = DateTime.TryParse(input, out DateTime parsedDate);

                if (!isValidDate)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid date. Please enter valid date");
                    continue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    int result = AgeCalcuator(parsedDate);
                    Console.WriteLine("Your age is: " + result);
                    break;
                }
            }
        }

        static int AgeCalcuator(DateTime birthdayDate)
        {
        //    DateTime userBirthdate = DateTime.Parse(birthdayDate);
            int userBirthYear = birthdayDate.Year;
            int userBirthMonth = birthdayDate.Month;
            int userBirthDay = birthdayDate.Day;

            DateTime currentDate = DateTime.Today;
            int currentYear = currentDate.Year;
            int currentMonth = currentDate.Month;
            int currentDay = currentDate.Day;

            if (currentMonth < userBirthMonth)
            {
                return currentYear - userBirthYear - 1;
            }
            else if(currentMonth == userBirthMonth)
            {
                if(currentDay < userBirthDay)
                {
                    return currentYear - userBirthYear - 1;
                } else
                {
                    return currentYear - userBirthYear;
                }
            }
            else
            {
                return currentYear - userBirthYear;
            }
        }
    }
}

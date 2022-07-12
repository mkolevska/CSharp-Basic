using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AcademyManagement.Services.Menus
{
    public class Screen
    {
        public static void HomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("============================ ACADEMY MENAGER ============================");
            Console.ResetColor();
        }

        public static void StartMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Welcome to the SEDC academy!");
            Console.WriteLine("Choose one of the numbers in front of the options to navigate the application");
            Console.WriteLine("1. Login as Admin");
            Console.WriteLine("2. Login as Trainer");
            Console.WriteLine("3. Login as Student");
            Console.WriteLine("4. Exit the application");
            Console.WriteLine("");
            Console.ResetColor();
        }

        public static void AdminMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Choose on of the following options:");
            Console.WriteLine("1. Add new admin");
            Console.WriteLine("2. Add new trainer");
            Console.WriteLine("3. Add new student");
            Console.WriteLine("4. Remove admin");
            Console.WriteLine("5. Remove trainer");
            Console.WriteLine("6. Remove student");
            Console.WriteLine("7. Logout");
            Console.WriteLine("");
            Console.ResetColor();
        }

        public static void TrainerMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Choose on of the following options:");
            Console.WriteLine("1. See all students");
            Console.WriteLine("2. See all subjects");
            Console.WriteLine("3. Logout");
            Console.WriteLine("");
            Console.ResetColor();
        }

        public static void StudentMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Press '1' to logout");
        }
    }
}

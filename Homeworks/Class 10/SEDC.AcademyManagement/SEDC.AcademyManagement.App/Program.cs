using SEDC.AcademyManagement.Data.Database;
using SEDC.AcademyManagement.Services.Menus;
using SEDC.AcademyManagement.Services.UserServices;
using System;

namespace SEDC.AcademyManagement.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Academy Management App";
            var academyMenagement = new UserService();
            academyMenagement.Main();
        }
    }
}

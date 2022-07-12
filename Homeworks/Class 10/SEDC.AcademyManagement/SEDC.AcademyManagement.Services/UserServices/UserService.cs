using SEDC.AcademyManagement.Data.Database;
using SEDC.AcademyManagement.Data.BaseModels;
using SEDC.AcademyManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SEDC.AcademyManagement.Services.Menus;
using System.Threading;

namespace SEDC.AcademyManagement.Services.UserServices
{
    public class UserService
    {
        private UserRepository userRepository = new UserRepository();
        private Validations validation = new Validations();
        private TrainerService trainerService = new TrainerService();
        private AdminService adminService = new AdminService();
        public void Main()
        {
            StartOptions();
        }

        public void StartOptions()
        {
            while (true)
            {
                Console.Clear();
                Screen.HomeScreen();
                Screen.StartMenu();
                string selection = Console.ReadLine();

                if (selection == "1")
                {
                    var admin = LoginAsAdmin();
                    adminService.AdminMenuMain(admin);
                    continue;
                }
                else if (selection == "2")
                {
                    var trainer = LoginAsTrainer();
                    trainerService.TrainerMenuMain(trainer);
                    continue;
                }
                else if (selection == "3")
                {
                    var student = LoginAsStudent();
                    StudentService.ShowSubjects(student);
                    continue; 
                }
                else if (selection == "4")
                {
                    Console.WriteLine("Thanks for using our app");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again");
                    Thread.Sleep(1000);
                    continue;
                }
            }
        }

        public Admin LoginAsAdmin()
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to the admin menu. Login using your username and password");
            while (true)
            {
                try
                {
                    string userName = validation.GetUserName();
                    var admin = userRepository.GetAdminByUserName(userName);
                    if (admin != null)
                    {
                        if (validation.ValidatePassword(admin))
                        {
                            admin.IsLoggedIn = true;
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Welcome {admin.FullName}");
                            Console.ResetColor();
                            return admin;
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid username. Try again");
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }
        public Trainer LoginAsTrainer()
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to the trainer menu. Login using your username and password");
            while (true)
            {
                try
                {
                    string userName = validation.GetUserName();
                    var trainer = userRepository.GetTrainerByUserName(userName);
                    if (trainer != null)
                    {
                        if (validation.ValidatePassword(trainer))
                        {
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Welcome {trainer.FullName}");
                            Console.ResetColor();
                            return trainer;
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid username. Try again");
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }

        }

        public Student LoginAsStudent()
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to the student menu. Login using your username and password");
            while (true)
            {
                try
                {
                    string userName = validation.GetUserName();
                    var student = userRepository.GetStudentByUserName(userName);
                    if (student != null)
                    {
                        if (validation.ValidatePassword(student))
                        {
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Welcome {student.FullName}");
                            Console.ResetColor();
                            return student;
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid username. Try again");
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }
    }
}
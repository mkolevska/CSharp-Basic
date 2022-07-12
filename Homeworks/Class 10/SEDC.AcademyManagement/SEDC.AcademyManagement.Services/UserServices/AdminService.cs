using SEDC.AcademyManagement.Data.Database;
using SEDC.AcademyManagement.Data.Models;
using SEDC.AcademyManagement.Services.Menus;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AcademyManagement.Services.UserServices
{
    public class AdminService
    {
        private UserRepository userRepository = new UserRepository();
        private Validations validation = new Validations();
        public void AdminMenuMain(Admin admin)
        {
            while (true)
            {
                Screen.AdminMenu();
                string selection = Console.ReadLine();
                if (selection == "1")
                {
                    AddNewAdmin();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have succesfully added a new admin!");
                    Console.ResetColor();
                    Console.WriteLine("");
                    continue;
                }
                else if (selection == "2")
                {
                    AddNewTrainer();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have succesfully added a new trainer!");
                    Console.ResetColor();
                    Console.WriteLine("");
                    continue;
                }
                else if (selection == "3")
                {
                    AddNewStudent();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have succesfully added a new student!");
                    Console.ResetColor();
                    Console.WriteLine("");
                    continue;
                }
                else if (selection == "4")
                {
                    RemoveAdmin();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have succesfully removed an admin!");
                    Console.ResetColor();
                    Console.WriteLine("");
                    continue;
                }
                else if (selection == "5")
                {
                    RemoveTrainer();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have succesfully removed a trainer!");
                    Console.ResetColor();
                    Console.WriteLine("");
                    continue;
                }
                else if (selection == "6")
                {
                    RemoveStudent();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have succesfully removed a student!");
                    Console.ResetColor();
                    Console.WriteLine("");
                    continue;

                }
                else if (selection == "7")
                {
                    admin.IsLoggedIn = false;
                    Console.WriteLine("You have logout");
                    break;
                }
                else
                {
                    Console.WriteLine("invalid selection. Try again");
                    continue;
                }
            }
        }
        public void AddNewAdmin()
        {
            while (true)
            {
                try
                {
                    int id = validation.ValidateAdminId();

                    string fullName = validation.ValidateName();

                    string validatedUserName = validation.ValidateAdminUserName();

                    string password = validation.ValidatePasswordInput();

                    Admin newAdmin = new Admin(id, fullName, validatedUserName, password);
                    InMemoryDatabase.Admins.Add(newAdmin);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void AddNewTrainer()
        {
            while (true)
            {
                try
                {
                    int id = validation.ValidateTrainerId();

                    string fullName = validation.ValidateName();

                    string validatedUserName = validation.ValidateTrainerUserName();

                    string password = validation.ValidatePasswordInput();

                    Trainer newTrainer = new Trainer(id, fullName, validatedUserName, password);
                    InMemoryDatabase.Trainers.Add(newTrainer);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void AddNewStudent()
        {
            var subjects = userRepository.GetAllSubjects();
            while (true)
            {
                try
                {
                    int id = validation.ValidateStudentId();

                    string fullName = validation.ValidateName();

                    string validatedUserName = validation.ValidateStudentUserName();

                    string password = validation.ValidatePasswordInput();

                    Student newStudent = new Student(id, fullName, validatedUserName, password, subjects[0], subjects);
                    InMemoryDatabase.Students.Add(newStudent);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private void RemoveAdmin()
        {
            while (true)
            {
                try
                {
                    var admins = InMemoryDatabase.Admins;

                    string userName = validation.GetUserName();
                    var admin = userRepository.GetAdminByUserName(userName);

                    if (admin != null)
                    {
                        if (userName == admin.UserName)
                        {
                            if (admin.IsLoggedIn == true)
                            {
                                throw new Exception("You cant remove yourself");
                            }
                            else
                            {
                                admins.Remove(admin);
                                break;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("There is no admin with that username.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void RemoveTrainer()
        {
            while (true)
            {
                try
                {
                    var trainers = InMemoryDatabase.Trainers;
                    string userName = validation.GetUserName();
                    var trainer = userRepository.GetTrainerByUserName(userName);

                    if (trainer != null)
                    {
                        if (trainer.UserName == userName)
                        {
                            trainers.Remove(trainer);
                            break;
                        }
                    }
                    else
                    {
                        throw new Exception("There is no trainer with that username.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private void RemoveStudent()
        {
            while (true)
            {
                try
                {
                    var students = InMemoryDatabase.Students;
                    string userName = validation.GetUserName();
                    var student = userRepository.GetStudentByUserName(userName);

                    if (student != null)
                    {
                        if (student.UserName == userName)
                        {
                            students.Remove(student);
                            break;
                        }
                    }
                    else
                    {
                        throw new Exception("There is no student with that username.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

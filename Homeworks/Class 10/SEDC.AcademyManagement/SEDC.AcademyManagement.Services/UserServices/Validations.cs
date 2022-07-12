using SEDC.AcademyManagement.Data.BaseModels;
using SEDC.AcademyManagement.Data.Database;
using SEDC.AcademyManagement.Data.Models;
using SEDC.AcademyManagement.Services.Menus;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AcademyManagement.Services.UserServices
{
    class Validations
    {
        private UserRepository userRepository = new UserRepository();
        public string GetUserName()
        {
            Console.WriteLine("Enter username");
            string userName = Console.ReadLine();

            return userName;
        }
        public bool ValidatePassword(User user)
        {
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            if (user.Password == password)
            {
                return true;
            }
            else
            {
                throw new Exception("invalid password. Try again !");
            }
        }

        public int ValidateInteger(string input)
        {
            while (true)
            {
                try
                {
                    bool isValid = int.TryParse(input, out int number);

                    if (!isValid)
                    {
                        throw new Exception("Enter valid number. Try again");
                    }
                    else
                    {
                        return number;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public int ValidateAdminId()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter ID");
                    string id = Console.ReadLine();
                    bool isValid = int.TryParse(id, out int number);

                    if (!isValid)
                    {
                        throw new Exception("Enter valid number. Try again");
                    }
                    else
                    {
                        var admin = userRepository.GetAdminById(number);
                        if (admin == null)
                        {
                            return number;
                        }
                        else
                        {
                            throw new Exception("There is already admin with that id. Try another one");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public int ValidateTrainerId()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter ID");
                    string id = Console.ReadLine();
                    bool isValid = int.TryParse(id, out int number);

                    if (!isValid)
                    {
                        throw new Exception("Enter valid number. Try again");
                    }
                    else
                    {
                        var trainer = userRepository.GetTrainerById(number);
                        if (trainer == null)
                        {
                            return number;
                        }
                        else
                        {
                            throw new Exception("There is already trainer with that id. Try another one");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public int ValidateStudentId()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter ID");
                    string id = Console.ReadLine();
                    bool isValid = int.TryParse(id, out int number);

                    if (!isValid)
                    {
                        throw new Exception("Enter valid number. Try again");
                    }
                    else
                    {
                        var student = userRepository.GetStudentById(number);
                        if (student == null)
                        {
                            return number;
                        }
                        else
                        {
                            throw new Exception("There is already student with that id. Try another one");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public string ValidateName()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter fullname");
                    string input = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(input))
                    {
                        throw new Exception("Name must contain at least one character");
                    }
                    else
                    {
                        return input;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public string ValidateAdminUserName()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter username");
                    string input = Console.ReadLine();

                    var admins = userRepository.GetAllAdmins();

                    foreach (var admin in admins)
                    {
                        if (input == admin.UserName)
                        {
                            throw new Exception("There is already admin with that username. Try another");
                        }
                    }
                    return input;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
        }

        public string ValidateTrainerUserName()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter username");
                    string input = Console.ReadLine();

                    var trainers = userRepository.GetAllTrainers();

                    foreach (var trainer in trainers)
                    {
                        if (input == trainer.UserName)
                        {
                            throw new Exception("There is already trainer with that username. Try another");
                        }
                    }
                    return input;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
        }

        public string ValidateStudentUserName()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter username");
                    string input = Console.ReadLine();

                    var students = userRepository.GetAllStudents();

                    foreach (var student in students)
                    {
                        if (input == student.UserName)
                        {
                            throw new Exception("There is already student with that username. Try another");
                        }
                    }
                    return input;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
        }

        public string ValidatePasswordInput()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter password");
                    string input = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(input))
                    {
                        throw new Exception("password must contain at least one character");
                    }
                    else
                    {
                        return input;
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


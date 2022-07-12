using SEDC.AcademyManagement.Data.Database;
using SEDC.AcademyManagement.Data.Models;
using SEDC.AcademyManagement.Services.Menus;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AcademyManagement.Services.UserServices
{
    public class TrainerService
    {
        private UserRepository userRepository = new UserRepository();
        private Validations validation = new Validations();
        public void TrainerMenuMain(Trainer trainer)
        {
            while (true)
            {
                Screen.TrainerMenu();
                string selection = Console.ReadLine();

                if (selection == "1")
                {
                    ShowStudentSubject();
                    continue;
                }
                else if (selection == "2")
                {
                    showSubjects();
                    continue;
                }
                else if(selection == "3")
                {
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
        private void ShowStudents()
        {
            var students = userRepository.GetAllStudents();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id}. {student.FullName}");
            }
        }

        private void ShowStudentSubject()
        {
            ShowStudents();

            while (true)
            {
                try
                {
                    Console.WriteLine("Choose one of the students to see their subjects");
                    string selection = Console.ReadLine();
                    int selectedStudent = validation.ValidateInteger(selection);

                    var student = userRepository.GetStudentById(selectedStudent);
                    if (student != null)
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Chosen student: {student.FullName}");
                        Console.ResetColor();
                        Console.WriteLine($"Student current subject: {student.CurrentSubject.Name}");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Student finished subjects:");
                        Console.ResetColor();
                        foreach (var subject in student.FinishedSubjects)
                        {
                            Console.WriteLine(subject.Name);
                        }
                        break;
                    }
                    else
                    {
                        throw new Exception("Invalid selection. Choose one of the numbers of the student");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
        }

        private void showSubjects()
        {
            var subjects = userRepository.GetSubjects();
            var students = userRepository.GetAllStudents();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===== SUBJECTS =====");
            Console.ResetColor();
            foreach (var subject in subjects)
            {
                int counter = 0;

                foreach (var student in students)
                {
                    if (subject.Name == student.CurrentSubject.Name)
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"subject: {subject.Name} - Students currently attending the class: {counter}");
            }
        }
    }
}

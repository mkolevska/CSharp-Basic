using SEDC.AcademyManagement.Data.Models;
using SEDC.AcademyManagement.Services.Menus;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AcademyManagement.Services.UserServices
{
    public class StudentService
    {
        private static Dictionary<string, int> AddGradesToFinishedSubjects(List<Subject> subjects)
        {
            Dictionary<string, int> grades = new Dictionary<string, int>();

            for (int i = 0; i < subjects.Count; i++)
            {
                int randomNum = new Random().Next(6, 10);
                grades.Add(subjects[i].Name, randomNum);
            }
            return grades;
        }
        public static void ShowSubjects(Student student)
        {
            student.Grades = AddGradesToFinishedSubjects(student.FinishedSubjects);
            var currentSubject = student.CurrentSubject.Name;

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your current subject is {currentSubject}");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Your grades from previous subjects:");
            Console.ResetColor();
            if(student.FinishedSubjects.Count == 0)
            {
                Console.WriteLine("You dont have finished subjects");
            }
            else
            {
                foreach (var subject in student.Grades)
                {
                    Console.WriteLine($"{subject.Key} - {subject.Value}");
                }
            }

            while (true)
            {
                Screen.StudentMenu();
                string input = Console.ReadLine();
                if (input == "1")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                    continue;
                }
            }
            
        }
    }
}

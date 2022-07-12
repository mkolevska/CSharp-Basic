using SEDC.AcademyManagement.Data.BaseModels;
using SEDC.AcademyManagement.Data.Enummerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AcademyManagement.Data.Models
{
    public class Student : User
    {
        public Subject CurrentSubject { get; set; }
        public List<Subject> FinishedSubjects { get; set; }
        public Dictionary<string, int> Grades { get; set; }

        public Student(int id, string fullName, string userName, string password, Subject newSubject, List<Subject> finishedSubjects)
            : base(id, fullName, userName, password, Roles.Student)
        {
            if (CurrentSubject == null)
            {
                CurrentSubject = newSubject;
                CurrentSubject.IsActive = true;
            }
            else if (CurrentSubject != newSubject)
            {
                FinishedSubjects.Add(CurrentSubject);
                CurrentSubject = newSubject;
                CurrentSubject.IsActive = true;
            }
            else
            {
                throw new Exception("Already have that subject as your current subject");
            }

            FinishedSubjects = AddSubjects(finishedSubjects);
        }

        public List<Subject> AddSubjects(List<Subject> subjects)
        {
            List<Subject> finishedSubjects = new List<Subject>();
            for (int i = 0; i < subjects.Count; i++)
            {
                if (CurrentSubject == subjects[i])
                {
                    break;
                }
                else
                {
                    subjects[i].IsActive = false;
                    finishedSubjects.Add(subjects[i]);
                }
            }
            return finishedSubjects;
        }     
    }
}

using SEDC.AcademyManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SEDC.AcademyManagement.Data.BaseModels;

namespace SEDC.AcademyManagement.Data.Database
{
    public class UserRepository : InMemoryDatabase
    {
        public Admin GetAdminByUserName(string username)
        {
            return Admins.FirstOrDefault(admin => admin.UserName == username);
        }

        public Trainer GetTrainerByUserName(string username)
        {
            return Trainers.FirstOrDefault(trainer => trainer.UserName == username);
        }

        public Student GetStudentByUserName(string username)
        {
            return Students.FirstOrDefault(student => student.UserName == username);
        }

        public List<Student> GetAllStudents()
        {
            return Students;
        }
        
        public Student GetStudentById(int id)
        {
            return Students.FirstOrDefault(student => student.Id == id);
        }

        public Trainer GetTrainerById(int id)
        {
            return Trainers.FirstOrDefault(trainer => trainer.Id == id);
        }

        public Admin GetAdminById(int id)
        {
            return Admins.FirstOrDefault(admin => admin.Id == id);
        }

        public List<Subject> GetSubjects()
        {
            return Subjects;
        }

        public Subject GetSubjectById(int id)
        {
            return Subjects.FirstOrDefault(subject => subject.Id == id);
        }

        public List<Admin> GetAllAdmins()
        {
            return Admins;
        }

        public List<Trainer> GetAllTrainers()
        {
            return Trainers;
        }

        public List<Subject> GetAllSubjects()
        {
            return Subjects;
        }
    }
}

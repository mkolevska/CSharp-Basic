using SEDC.AcademyManagement.Data.BaseModels;
using SEDC.AcademyManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AcademyManagement.Data.Database
{
    public class InMemoryDatabase
    {
        public List<Subject> Subjects { get; set; }
        public static List<Admin> Admins { get; set; }
        public static List<Trainer> Trainers { get; set; }
        public static List<Student> Students { get; set; }
        public InMemoryDatabase()
        {
            InitDatabase();
        }

        public void InitDatabase()
        {
            Subjects = new List<Subject>
            {
                new Subject(1, "HTML", new DateTime(2021, 10, 01), new DateTime(2021, 11, 01), false),
                new Subject(2, "CSS", new DateTime(2021, 11, 02), new DateTime(2021, 12, 01), false),
                new Subject(3, "Basic JS", new DateTime(2021, 12, 02), new DateTime(2022, 01, 11), false),
                new Subject(4, "Advanced JS", new DateTime(2022, 01, 12), new DateTime(2022, 02, 28), false),
                new Subject(5, "Basic C#", new DateTime(2022, 03, 01), new DateTime(2022, 03, 31), false),
                new Subject(6, "Advanced C#", new DateTime(2022, 04, 01), new DateTime(2022, 05, 15), false)
            };

            Admins = new List<Admin>
            {
                new Admin(1, "Administrator1", "admin1", "admin1"),
                new Admin(2, "Administrator2", "admin2", "admin2")
            };

            Trainers = new List<Trainer>
            {
                new Trainer(1, "Trajan Stevkovski", "trajan", "trajan123"),
                new Trainer(2, "Vlatko Tasevski", "vlatko", "vlatko123")
            };

            Students = new List<Student>
            {
                new Student(1, "Marija Kolevska", "marija123", "marija123", Subjects[4], Subjects),
                new Student(2, "Ilija Mitev", "iija123", "ilija123", Subjects[4], Subjects),
                new Student(3, "Maja Nikolovska", "majauduks", "majauduks123", Subjects[4], Subjects),
                new Student(4, "Ana Kirovska", "ana1234", "ana123", Subjects[0], Subjects),
                new Student(5, "Aneta Stankovska", "anesta", "aneta123", Subjects[4], Subjects)
            };
        }
    }
}

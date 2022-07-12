using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ExtraHomework.Class05.Hogwarts.Models
{
    public class Wizards
    {
        public string Name { get; set; }
        public int PowerLevel { get; set; }
        public int Age { get; set; }
        public DateTime DateOfAdmission { get; set; }
        public bool GraduationStatus { get; set; }
        public int ID { get; set; }

        public Wizards(string name, int powerLevel, int age, DateTime admission, bool isGraduate, int id )
        {
            Name = name;
            PowerLevel = powerLevel;
            Age = age;
            DateOfAdmission = admission;
            GraduationStatus = isGraduate;
            ID = id;
        }
    }
}

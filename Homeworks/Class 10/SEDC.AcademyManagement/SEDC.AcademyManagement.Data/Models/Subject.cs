using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AcademyManagement.Data.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }

        public Subject(int id, string name, DateTime dos, DateTime doe, bool isActive)
        {
            Id = id;
            Name = name;
            StartDate = dos;
            EndDate = doe;
            IsActive = isActive;
        }
    }
}

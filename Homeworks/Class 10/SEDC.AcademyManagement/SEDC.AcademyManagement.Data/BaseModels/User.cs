using SEDC.AcademyManagement.Data.Enummerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AcademyManagement.Data.BaseModels
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public Roles Role { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(int id, string fullName, string userName, string password, Roles role)
        {
            Id = id;
            FullName = fullName;
            UserName = userName;
            Password = password;
            Role = role;
        }
    }
}

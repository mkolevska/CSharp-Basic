using SEDC.AcademyManagement.Data.BaseModels;
using SEDC.AcademyManagement.Data.Enummerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AcademyManagement.Data.Models
{
    public class Trainer : User
    {
        public Trainer(int id, string fullName, string userName, string password)
            : base(id, fullName, userName, password, Roles.Trainer)
        {

        }
    }
}

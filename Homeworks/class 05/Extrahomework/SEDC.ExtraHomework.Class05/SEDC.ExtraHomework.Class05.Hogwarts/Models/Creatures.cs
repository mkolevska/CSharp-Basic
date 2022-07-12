using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ExtraHomework.Class05.Hogwarts.Models
{
    public class Creatures
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int PowerLevel { get; set; }
        public bool IsTamed { get; set; }
        public int ID { get; set; }

        public Creatures(string name, int age, int powerLevel, bool isTamed, int id)
        {
            Name = name;
            Age = age;
            PowerLevel = powerLevel;
            IsTamed = isTamed;
            ID = id;
        }


    }
}

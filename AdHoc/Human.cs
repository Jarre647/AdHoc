using System;
using System.Collections.Generic;
using System.Text;

namespace AdHoc
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Human() { }
        public Human(string name)
        {
            Name = name;
        }
        public Human(string name, int age) : this(name)
        {
            Age = age;
        }
    }
    class Gender : Human
    {
        public string GenderName { get; set; }
        public Gender(string name, int age, string genderName) : base(name, age)
        {
            GenderName = genderName;
        }
    }
}

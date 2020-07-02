using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Carlos_Akel
{
    class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private string Nation { get; set; }
        private int Salary { get; set; }

        public Person(string Name,int Age,string Nation,int Salary)
        {
            this.Name = Name;
            this.Age = Age;
            this.Nation = Nation;
            this.Salary = Salary;
        }

        public string Info()
        {
            return $"{Name} {Age} {Nation} {Salary}";
        }
        public string get_name()
        {
            return Name;
        }
        public int get_age()
        {
            return Age;
        }
        public string get_nation()
        {
            return $"{Nation}";
        }
        public int get_salary()
        {
            return Salary;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Carlos_Akel
{
    class Doctor : Person
    {
        private int experience { set; get; }

        public Doctor(string Name, int Age, string Nation, int Salary, int experience) : base(Name, Age, Nation, Salary)
        {

            this.experience = experience;
        }

        public bool Evaluate(Player p)
        {
            if(p.get_condition() == false)
            {
                return false;
            }
            return true;
        }
        public void Cure(Player p)
        {
            p.change_condition(true); 
        }
    }
}

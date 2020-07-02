using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Carlos_Akel
{
    class Player : Person
    {
        private int Atack { get; set; }
        private int Defence { get; set; }
        private int Number { get; set; }
        private bool Arquero { get; set; }
        private bool En_cancha { get; set; }
        private bool Condition { get; set; }//si es verdadero su condicion es sana de lo contrario esta herido


        public Player(string Name,int Age,string Nation,int Salary,int Atack,int Defence ,int Number, bool Arquero,bool En_cancha,bool Condition) :base( Name,  Age, Nation,Salary)
        {
            this.Atack = Atack;
            this.Defence = Defence;
            this.Number = Number;
            this.Arquero = Arquero;
            this.En_cancha = En_cancha;
            this.Condition = Condition;

        }
        public bool get_arquero()
        {
            return Arquero;
        }
        public bool get_en_cancha()
        {
            return En_cancha;
        }
        public void change_cancha(bool u)
        {
            En_cancha = u;
        }
        public void change_arquero(bool u2)
        {
            Arquero = u2;
        }
        public bool get_condition()//te de la condicion del jugador
        {
            return Condition;
        }
        public void change_condition(bool t)
        {
            Condition = t;
        }

    }
}

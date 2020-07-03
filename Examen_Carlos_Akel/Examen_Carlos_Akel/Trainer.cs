using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Carlos_Akel
{
    class Trainer : Person
    {

        private int TacticPoints { get; set; }


        public Trainer(string Name, int Age, string Nation, int Salary, int TacticPoints) : base(Name, Age, Nation, Salary)
        {

            this.TacticPoints = TacticPoints;
        }
        public delegate void statusEventHandler(object source, EventArgs a);
        public event statusEventHandler Match_Status;//se genera el metodo para checkear el status del partido
        protected virtual void OnMatch_Status()
        {
            if (Match_Status != null)
            {
                Match_Status(this, new EventArgs());//se genera el eventoo
            }
        }
        public void test_status_evente()
        {
            OnMatch_Status();//probar el evento
        }


        public void Change_Player(Player p,Player p2)//el primero es el jugador que quieres cambier y el segundo es el jugador el cual va ser cambiado si no se encuentra en cancha
        {
            if(p.get_en_cancha() == true && p.get_arquero() == false && p2.get_en_cancha() == false && p2.get_arquero() == false)
            {
                p.change_cancha(false);
                p2.change_cancha(true);
            }
            else if(p.get_arquero() == true && p.get_en_cancha() == false && p2.get_arquero() == false && p2.get_en_cancha() == false)
            {
                p.change_arquero(false);
                p2.change_arquero(true);
            }
        }

        public Player check_team_condition(List<Player> p)
        {
            foreach(Player item in p)
            {
                if(item.get_condition() == false)
                {
                    return item;
                }
            }
            return null;// no retorna nada pues la condicion de todos los jugadores es buena
        }
    }
}

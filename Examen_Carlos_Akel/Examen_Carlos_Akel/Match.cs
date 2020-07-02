using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Carlos_Akel
{
    class Match
    {
        private Tuple<Team, Team> Teams {get;set;} 
        private int Time { get; set; }
        private string Outcome { get; set; }

        //private bool League_or_National { get; set; }// si es verdadero es de liga y si es falso es Nacional

        public Match(Tuple<Team, Team> Teams,int Time, string Outcome)
        {
            this.Teams = Teams;
            this.Time = Time;
            this.Outcome = Outcome;
            //this.League_or_National = League_or_National;
        }

        public string play_match()
        {
            if(Teams.Item1.get_league_or_national() == Teams.Item1.get_league_or_national())
            {
                return $"Game is played";
            }
            else
            {
                return $"Both teams are not  national or league";
            }

        }
        public void Check_match_status()
        {
            if(Teams.Item1.get_t() != null)
            {

                Console.WriteLine("Se efectuara un cambio");
                Console.WriteLine("Ingrese el nombre un jugador que no se encuentre en la cancha");

            }
            else if(Teams.Item1.get_t() != null)
            {

                Console.WriteLine("Se efectuara un cambio");
                Console.WriteLine("Ingrese el nombre un jugador que no se encuentre en la cancha");
            }
            
        }


    }
}

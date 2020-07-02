using System;
using System.Collections.Generic;
using System.Linq;
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
        public void OnMatch_Status(object source, EventArgs e)
        {
            if(Teams.Item1.get_t() != null)
            {

                Console.WriteLine("Se efectuara un cambio");
                Console.WriteLine("Ingrese el nombre un jugador que se encuentre en la banca");
                string name = Console.ReadLine();
                bool cond = true;
                if(Teams.Item1.get_t().get_en_cancha() == true)
                {
                    foreach (Player play in Teams.Item1.get_p())
                    {
                        if (play.get_name().ToUpper() == name.ToUpper() && play.get_en_cancha() == false && play.get_arquero() == false)
                        {
                            Teams.Item1.get_trainer2().Change_Player(Teams.Item1.get_t(), play);
                            cond = false;
                        }
                    }

                    
                }
                else if (Teams.Item1.get_t().get_arquero() == true)
                {
                    foreach (Player play in Teams.Item1.get_p())
                    {
                        if (play.get_name().ToUpper() == name.ToUpper() && play.get_arquero() == false && play.get_en_cancha() == false)
                        {
                            Teams.Item1.get_trainer2().Change_Player(Teams.Item1.get_t(), play);
                            cond = false;
                        }
                    }
                }
                else if(cond == true)
                {
                    Console.WriteLine("No existe o no cumple con las condiciones el jugador ingresado chequea el status del partido nuevamente");
                }


            }
            else if(Teams.Item1.get_t() != null)
            {
                Console.WriteLine("Se efectuara un cambio");
                Console.WriteLine("Ingrese el nombre un jugador que se encuentre en la banca");
                string name = Console.ReadLine();
                bool cond2 = true;
                if (Teams.Item2.get_t().get_en_cancha() == true)
                {
                    foreach (Player play in Teams.Item2.get_p())
                    {
                        if (play.get_name().ToUpper() == name.ToUpper() && play.get_en_cancha() == false && play.get_arquero() == false)
                        {
                            Teams.Item2.get_trainer2().Change_Player(Teams.Item2.get_t(), play);
                            cond2 = false;
                        }
                    }


                }
                else if (Teams.Item2.get_t().get_arquero() == true)
                {
                    foreach (Player play in Teams.Item2.get_p())
                    {
                        if (play.get_name().ToUpper() == name.ToUpper() && play.get_arquero() == false && play.get_en_cancha() == false)
                        {
                            Teams.Item2.get_trainer2().Change_Player(Teams.Item2.get_t(), play);
                            cond2 = false;
                        }
                    }
                }
                else if (cond2 == true)
                {
                    Console.WriteLine("No existe o no cumple con las condiciones el jugador ingresado chequea el status del partido nuevamente");
                }
            }
            
        }


    }
}

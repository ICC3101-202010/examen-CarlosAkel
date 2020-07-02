using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen_Carlos_Akel
{
    class Team
    {
        private List<Player> players {get;set;}
        private Doctor doctor { get; set; }
        private Trainer trainer { get; set; }
        private bool League_or_National { get; set; }// si es verdadero es de liga y si es falso es Nacional

        public Team(List<Player> players,Doctor doctor,Trainer trainer, bool League_or_National)
        {
            this.players = players;
            this.doctor = doctor;
            this.trainer = trainer;
            this.League_or_National = League_or_National;
        }

        public void Remove_Player(string PlayerName)
        {
            if(players.Count() != 0)
            {
                foreach(Player item in players)
                {
                    if(item.get_name() == PlayerName)
                    {
                        players.Remove(item);
                    }
                }
            }

        }
        public void Add_Player(string Name,int Age,string Nation,int Salary,int Atack,int Defence,int Number, bool Arquero,bool cancha,bool condition)
        {
            if(players.Count() < 15)
            {
                int cant_en_cancha = 0;
                foreach (Player item in players)
                {
                    if (item.get_arquero() == true || item.get_arquero() == true || item.get_en_cancha() == true )
                    {
                        return;//si ya existe el arquero no te agrega el jugador o estas tratando de ingresar a alguien en cancha y de arquero
                    }
                    if(item.get_nation().ToUpper() != Nation.ToUpper())
                    {
                        return;//El jugador agragado  es de una nacionalidad diferente
                    }
                    if(item.get_en_cancha() == true)
                    {
                        cant_en_cancha++;
                    }
                    if(cant_en_cancha >= 10)
                    {
                        return; // ya hay 10 jugadores en cancha
                    }
                }


                Player p = new Player(Name, Age, Nation, Salary, Atack, Defence, Number, Arquero, cancha,condition);
                players.Add(p);//agrega el nuevo jugador
            }
        }
        public bool get_league_or_national()
        {
            return League_or_National;
        }

        public Player get_t()//te da el chequeo del  equipo por parte del entrenador
        {
            return trainer.check_team_condition(players);
        }
        public Trainer get_trainer2()
        {
            return trainer;
        }


    }
}

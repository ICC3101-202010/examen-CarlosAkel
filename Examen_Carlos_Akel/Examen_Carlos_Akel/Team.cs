using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen_Carlos_Akel
{
    class Team : Datos_pj
    {
        private List<Player> players {get;set;}
        private Doctor doctor { get; set; }
        private Trainer trainer { get; set; }
        private bool League_or_National { get; set; }// si es verdadero es de liga y si es falso es Nacional
        public delegate void statusEventHandler(object source, EventArgs a);
        public event statusEventHandler Match_Status;//se genera el metodo para checkear el status del partido
        protected virtual void OnMatch_Status()
        {
            if(Match_Status != null)
            {
                Match_Status(this, new EventArgs());//se genera el eventoo
            }
        }
        public void test_status_evente()
        {
            OnMatch_Status();//probar el evento
        }


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
        public  List<Player> get_p()//retorna los jugadores
        {
            return players;
        }

        public string get_player_name(int p)
        {
            foreach(Player item in players)
            {
                if(item.get_number() == p)
                {
                    return $"{item.get_name()}";
                }
            }
            return $"mal ingresado o no existe";
        }
        public int get_total_players()
        {
            return players.Count();
        }


        public void get_all_players_data()
        {
            foreach(Player item in players)
            {
                Console.WriteLine("Name: " + item.get_name() + " Age: " + item.get_age() + " Nation: " + item.get_nation() + " Salary: " + item.get_salary());
                Console.WriteLine("Atack: " + item.get_atack() + " Defence: " + item.get_defence() + " Number: " + item.get_number());
            }
        }

        public void get_doctor_data()
        {

            Console.WriteLine("Name: " + doctor.get_name() + " Age: " + doctor.get_age() + " Nation: " + doctor.get_nation() + " Salary: " + doctor.get_salary());
 
        }

        public void get_trainer_data()
        {
            Console.WriteLine("Name: " + trainer.get_name() + " Age: " + trainer.get_age() + " Nation: " + trainer.get_nation() + " Salary: " + trainer.get_salary());
        }
    }
}

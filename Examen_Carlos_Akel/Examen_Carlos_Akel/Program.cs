using System;

namespace Examen_Carlos_Akel
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player("Carlos", 20, "Chileno", 20000,20,20,20,false,true,true);

            Console.WriteLine(p.Info());
            Console.WriteLine(p.get_atack());
        }
    }
}

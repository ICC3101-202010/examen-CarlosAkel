using System;

namespace Examen_Carlos_Akel
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Carlos", 20, "Chileno", 20000);

            Console.WriteLine(p.Info());
        }
    }
}

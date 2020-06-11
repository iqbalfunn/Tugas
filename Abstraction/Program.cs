using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            ISuara suara = new Suara();
            suara.View();

            Mobil klakson;

            klakson = new Avanza();
            klakson.Klakson();
            Console.WriteLine();
            klakson = new Civic();
            klakson.Klakson();
            Console.WriteLine();
            klakson = new Bus();
            klakson.Klakson();

            Console.ReadKey();
        }
    }
}

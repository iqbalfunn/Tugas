using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public interface ISuara
    {
        void View();
    }

    class Suara : ISuara
    {
        public void View()
        {
            Console.WriteLine("Suara-Suara Kendaraan");
            Console.WriteLine("Berikut Contohnya : ");
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanPolymorphism2
{
    public class LaserJet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
        }

        public void Print()
        {
            Console.WriteLine("LaserJet printer printing.....");
        }
    }
}

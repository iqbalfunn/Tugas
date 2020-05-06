using System;
using System.Collections.Generic;
using System.Text;

namespace TugasPolymorphism
{
    public class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Laserjet display dimension : 12*12");
        }

        public override void Print()
        {
            Console.WriteLine("Laserjet printer printing.....");
        }
    }
}

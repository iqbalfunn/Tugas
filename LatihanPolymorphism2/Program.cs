using System;

namespace LatihanPolymorphism2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih Nomor Printer");
            Console.WriteLine("1.Epson");
            Console.WriteLine("2.Canon");
            Console.WriteLine("3.LaserJet");

            Console.WriteLine("Pilih Nomor Printer [1..3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            IPrinterWindows convert;

            if (nomorPrinter == 1)
                convert = new Epson();
                
            else if (nomorPrinter == 2)
                convert = new Canon();
      
            else
                convert = new LaserJet();

            convert.Show();
            convert.Print();
            Console.ReadKey();
        }
    }
}

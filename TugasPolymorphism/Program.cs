using System;

namespace TugasPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1.Epson");
            Console.WriteLine("2.Canon");
            Console.WriteLine("3.LaserJet\n");

            Console.WriteLine("Nomor Printer [1/2/3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                printer = new Epson();
            else if (nomorPrinter == 2)
                printer = new Canon();
            else if (nomorPrinter == 3)
                printer = new LaserJet();
            else 
            {
                Console.WriteLine("Pilihan Tidak Tersedia");
            }
            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}

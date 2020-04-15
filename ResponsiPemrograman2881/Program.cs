using System;

namespace ResponsiPemrograman2881
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Karyawan karyawan1= new Karyawan (1, 19112881, "Iqbal", 7000000);
            karyawan1.gaji();
            Karyawan karyawan2 = new Karyawan(2, 19112899, "Budi ", 5000000);
            karyawan2.gaji();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("ASYIKKKKKKKK GAJI NAIK 10%!");
            Console.WriteLine(" ");
            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Karyawan karyawan3 = new Karyawan(1, 19112881, "Iqbal", 7000000);
            karyawan3.gajinaik();
            Karyawan karyawan4 = new Karyawan(2, 19112899, "Budi ", 5000000);
            karyawan4.gajinaik();
        }
    }
}

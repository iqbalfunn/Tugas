using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2881
{
    public class Karyawan
    {
        public Karyawan(int no, int nik, string nama, int gajibulanan)
        {
            No = no;
            Nik = nik;
            Nama = nama;
            GajiBulanan = gajibulanan;
        }

        public int No { get; set; }
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public void gaji()
        {
            Console.WriteLine("{0}.  {1} {2}      {3}", No, Nik, Nama, GajiBulanan);
            if (GajiBulanan < 0)
            {
                Console.WriteLine("Maaf Gaji Kurang dari 0");
            }
        }

        public void gajinaik()
        {
            Console.WriteLine("{0}.  {1} {2}     {3}", No, Nik, Nama, GajiBulanan + (GajiBulanan * 10 / 100));
            if (GajiBulanan < 0)
            {
                Console.WriteLine("Maaf Gaji Kurang dari 0");
            }
        }

    }
}
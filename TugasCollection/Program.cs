using System;
using System.Collections;
using System.Collections.Generic;

namespace TugasLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuam 11)";

            // membuat objek untuk semua karyawan

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "4324132";
            karyawanTetap.Nama = "Iqbal Fanani";
            karyawanTetap.GajiBulanan = 8000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "3423243";
            karyawanHarian.Nama = "Budi Hartono";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerJam = 15000;

            Sales sales = new Sales();
            sales.Nik = "6464564";
            sales.Nama = "Jimmy Sutanto";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 50000;

            // object class collection 
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik : {1}, Nama : {2}, Gaji : Rp.{3 : 0}",
                    noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                Console.WriteLine("Pilih Menu Aplikasi");
                Console.WriteLine();
                Console.WriteLine("1. Tambah Penjualan");
                Console.WriteLine("2. Hapus Penjualan");
                Console.WriteLine("3. Tampilkan Penjualan");
                Console.WriteLine("4. Keluar");
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            double nota, totalnota;
            string tanggal, customer, jenis;
            Console.WriteLine("Tambah Data Penjualan");
            Console.WriteLine();
            Console.WriteLine("Nota : ");
            nota = int.Parse(Console.ReadLine());
            Console.WriteLine("Tanggal : ");
            tanggal = Console.ReadLine();
            Console.WriteLine("Customer : ");
            customer = Console.ReadLine();
            Console.WriteLine("Jenis [T/K] : ");
            jenis = Console.ReadLine();
            Console.WriteLine("Total Nota : ");
            totalnota = int.Parse(Console.ReadLine());
            daftarPenjualan.Add(new Penjualan() { Nota = nota, Tanggal = tanggal, Customer = customer, Jenis = jenis, TotalNota = totalnota });
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
            Console.WriteLine("Hapus Data Penjualan");
            Console.WriteLine();
            double hapus;
            Console.WriteLine("Masukan Nota yang ingin di hapus : ");
            hapus = int.Parse(Console.ReadLine());
            int i = 0;
            foreach(Penjualan penjualan in daftarPenjualan)
            {
                if (hapus == penjualan.Nota)
                {
                    daftarPenjualan.RemoveAt(i);
                    break;
                }
                else
                {
                    Console.WriteLine("Nota tidak ditemukan");
                }
                i++;
            }
            Console.WriteLine("Data penjualan berhasil dihapus");
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            Console.WriteLine("Data Penjualan");
            Console.WriteLine();
            int no = 1;
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                if (penjualan.Jenis == "t" || penjualan.Jenis == "T")
                {
                    Console.WriteLine("{0}. {1}, {2}, {3}, Tunai, {4}",
                    no, penjualan.Nota, penjualan.Tanggal, penjualan.Customer, penjualan.TotalNota);
                }
                else if (penjualan.Jenis == "k" || penjualan.Jenis == "K")
                {
                    Console.WriteLine("{0}. {1}, {2}, {3}, Kredit, {4}",
                    no, penjualan.Nota, penjualan.Tanggal, penjualan.Customer, penjualan.TotalNota);
                }
                no++;
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}

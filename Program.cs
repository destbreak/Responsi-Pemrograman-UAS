using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
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

        static void TambahProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan produk ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus produk dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar produk yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}

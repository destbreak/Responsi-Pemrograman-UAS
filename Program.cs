using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        // Deklarasi Objek Collection untuk Menampung Objek Produk
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

                    case 4: // Keluar dari Program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("------------------------------");
            Console.WriteLine("PILIH MENU APLIKASI");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
        }

        static void TambahProduk()
        {
            Console.Clear();

            InputNotification();

            Produk Product = new Produk();
            Console.Write("Kode Produk  : ");
            Product.Code = Console.ReadLine();
            Console.Write("Nama Produk  : ");
            Product.Name = Console.ReadLine();
            Console.Write("Harga Beli   : ");
            Product.inPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Harga Jual   : ");
            Product.outPrice = Convert.ToDouble(Console.ReadLine());
            daftarProduk.Add(Product);

            InputSuccess();

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            DeleteNotification();

            string Code;
            int listNumber = 0;
            int state = -1;
            int stateNumber = -1;

            foreach(Produk Product in daftarProduk)
            {
                listNumber++;
                Console.WriteLine("{0}. {1} | {2} | {3} | {4}", listNumber, Product.Code, Product.Name, Product.inPrice, Product.outPrice);
            }

            if(listNumber == 0)
            {
                DeleteEmpty();
            }
            else
            {
                Console.WriteLine();

                Console.Write("Kode Produk : ");
                Code = Console.ReadLine();

                foreach(Produk Product in daftarProduk)
                {
                    stateNumber++;
                    if(Product.Code == Code)
                    {
                        state = stateNumber;
                    }
                }

                if(state != -1)
                {
                    daftarProduk.RemoveAt(state);
                    DeleteSuccess();
                }
                else
                {
                    DeleteFailed();
                }
            }
            Console.WriteLine();

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            PrintNotification();

            int listNumber = 0;
            foreach(Produk Product in daftarProduk)
            {
                listNumber++;
                Console.WriteLine("{0}. {1} | {2} | {3} | {4}", listNumber, Product.Code, Product.Name, Product.inPrice, Product.outPrice);
            }

            if(listNumber == 0)
            {
                PrintEmpty();
            }
            Console.WriteLine();

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void InputNotification()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("TAMBAH DATA PRODUK");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }

        static void InputSuccess()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("INPUT SUKSES");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }

        static void DeleteNotification()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("HAPUS DATA PRODUK");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }

        static void DeleteEmpty()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("HAPUS GAGAL. TIDAK ADA DATA");
            Console.WriteLine("------------------------------");
        }

        static void DeleteSuccess()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("DELETE SUKSES");
            Console.WriteLine("------------------------------");
        }

        static void DeleteFailed()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("DELETE GAGAL. KODE PRODUK TIDAK VALID");
            Console.WriteLine("------------------------------");
        }

        static void PrintNotification()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("DATA PRODUK");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }

        static void PrintEmpty()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("TIDAK ADA DATA");
            Console.WriteLine("------------------------------");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik4._12_31.Tivano_Bima_Kusuma_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Menu Makanan WarBang ===");
            Console.WriteLine("1. Nasi Goreng");
            Console.WriteLine("2. Mie Ayam");
            Console.WriteLine("3. Seblak Hot Jeletot");
            Console.WriteLine("Pilih Menu (1-3) : ");
            int pilihan = int.Parse(Console.ReadLine());

            switch (pilihan)
            {
                case 1: Console.WriteLine("Anda memilih Nasi Goreng Harga : Rp 15.000");   break;
                case 2: Console.WriteLine("Anda memilih Mie Ayam Harga : Rp 12.000");      break;
                case 3: Console.WriteLine("Anda memilih Seblak Hot Jeletot Harga RP 15.000"); break;
                default: Console.WriteLine("Menu tidak tersedia!"); break;
                Console.ReadLine();







            }





















        }
    }
}

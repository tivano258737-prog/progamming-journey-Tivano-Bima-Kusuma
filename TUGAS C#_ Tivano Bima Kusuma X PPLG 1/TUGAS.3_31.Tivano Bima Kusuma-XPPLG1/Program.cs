using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS._3_31.Tivano_Bima_Kusuma_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Angka(1 - 5):  ");
            int warna = int.Parse(Console.ReadLine());

            switch (warna)
            {
                case 1: Console.WriteLine("Warna Merah"); break;
                case 2: Console.WriteLine("Warna Biru"); break;
                case 3: Console.WriteLine("Warna Hijau"); break;
                case 4: Console.WriteLine("Warna Kuning"); break;
                case 5: Console.WriteLine("Warna Hitam"); break;
                Console.ReadLine();


            }
        }
    }
}

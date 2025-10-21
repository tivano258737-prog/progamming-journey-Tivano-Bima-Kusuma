using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik7._2_31.Tivano_Bima_Kusuma_XPPLG1
{
    internal class Program
    {
        static void SapaNama(string Nama)
        {
            Console.WriteLine(" Hallo, " + Nama + "!");
            Console.WriteLine(" Semangat belajar C# hari ini!");
        }
        static void Main(string[] args)
        {
            Console.Write(" Masukan nama Anda: ");
            string namaSiswa = Console.ReadLine();
            SapaNama(namaSiswa); // Memanggil fungsi dengan argumen
            Console.ReadLine();
        }
    }
}

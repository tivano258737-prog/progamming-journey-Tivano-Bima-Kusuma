using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik1._5__Tivano_Bima_Kusuma_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" === INPUT BIODATA SISWA ===");
            Console.Write(" NAMA SISWA   :");
            String nama = Console.ReadLine();
            Console.Write("KELAS   :");
            String kelas = Console.ReadLine();
            Console.Write("JENIS KELAMIN: ");
            String jk = Console.ReadLine();
            Console.Write("JURUSAN  :");
            String jur = Console.ReadLine();
            Console.WriteLine("=======================");
            Console.WriteLine("=== BIODATA SISWA ===");
            Console.WriteLine($"NAMA SISWA     : {nama}");
            Console.WriteLine($"KELAS          : {kelas}");
            Console.WriteLine($"JENIS KELAMIN  : {jk});
            Console.WriteLine($"JURUSAN        : {jur}");
            Console.WriteLine("=======================");
            Console.ReadLine();
        }
    }
}

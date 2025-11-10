using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS._2_31.Tivano_Bima_Kusuma_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Umur yang akan di input");
            int umur = int.Parse(Console.ReadLine());

            if (umur >= 60)
            {
                Console.WriteLine("Lansia");
            }
            else
            {
                Console.WriteLine("Bukan Lansia");
            }
            Console.ReadLine();





        }
    }
}

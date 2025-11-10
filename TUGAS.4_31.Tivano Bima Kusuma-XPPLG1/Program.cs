using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS._4_31.Tivano_Bima_Kusuma_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Input Jam 0-23 Ucapan Jam ===");
            int jam = int.Parse(Console.ReadLine());

            if (jam >= 6 && jam <= 11)
            {
                Console.WriteLine("Selamat Pagi");
            }
            else if (jam >= 12 && jam <= 15)
            {
                Console.WriteLine("Selamat Siang");
            }
            else if (jam >= 16 && jam <= 18)
            {
                Console.WriteLine("Selamat Sore");
            }
            else if (jam >= 19 && jam <= 23)
            {
                Console.WriteLine("Selamat Malam");
            }
            else if (jam >= 0 && jam <= 5)
            {
                Console.WriteLine("Selamat Malam");
            }
            else
            {
                Console.WriteLine("Jam Tidak Valid");




            }

            Console.ReadLine();





        }    
    }
}

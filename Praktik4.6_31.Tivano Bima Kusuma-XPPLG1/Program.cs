using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik4._6_31.Tivano_Bima_Kusuma_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan nilai ujian: ");
            int nilai = int.Parse(Console.ReadLine());

            if (nilai >= 75 )
            {
                Console.WriteLine("Lulus. ");
            }
            else
            {
                Console.WriteLine("Tidak Lulus. ");
            }
            Console.ReadLine();





        }
    }
}

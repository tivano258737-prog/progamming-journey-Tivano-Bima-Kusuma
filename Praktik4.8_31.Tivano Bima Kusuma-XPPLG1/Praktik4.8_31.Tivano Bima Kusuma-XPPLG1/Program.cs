using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik4._8_31.Tivano_Bima_Kusuma_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan angka: ");
            int angka = int.Parse(Console.ReadLine());

            if (angka > 0 )
            {
                Console.WriteLine("Angka Positif.");
            }
            else if (angka < 0 )
            {
                Console.WriteLine("Angka negatif.");
            }
            else
            {
                Console.WriteLine("Angka Nol.");
            }
            Console.ReadLine();




        }
    }
}

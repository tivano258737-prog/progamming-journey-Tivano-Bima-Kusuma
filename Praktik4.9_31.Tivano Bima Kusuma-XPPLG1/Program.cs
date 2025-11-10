using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik4._9_31.Tivano_Bima_Kusuma_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan umur: ");
            int umur = int.Parse(Console.ReadLine());

            if ( umur <5 )
            {
                Console.WriteLine("Tiket Gratis. ");
            }
            else if (umur <= 12)
            {
                Console.WriteLine("Harga Tiket: Rp 20.000");
            }
            else if (umur <= 60)
            {
                Console.WriteLine("Harga Tiket: Rp 50.000");
            }
            else
            {
                Console.WriteLine("Harga Tiket: Rp 30.000 (Diskon Lansia) ");
               
            }
             Console.ReadLine();

        }
    }
}

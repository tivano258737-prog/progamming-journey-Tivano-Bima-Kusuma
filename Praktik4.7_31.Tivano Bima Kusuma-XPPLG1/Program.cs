using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik4._7_31.Tivano_Bima_Kusuma_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan nilai: ");
            int nilai = int.Parse(Console.ReadLine());

            if (nilai >=90 )
            {
                Console.WriteLine("Predikat A ");
            }
            else if (nilai >= 75)
            {
                Console.WriteLine("Predikat B ");
            }
            else if (nilai >= 60 )
            {
                Console.WriteLine("Predikat C ");
            }
            else
            {
                Console.WriteLine("Predikat D ");
            }
            Console.ReadLine();
        }
    }
}

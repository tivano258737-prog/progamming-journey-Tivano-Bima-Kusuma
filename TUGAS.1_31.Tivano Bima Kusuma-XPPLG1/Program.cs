using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS._1_31.Tivano_Bima_Kusuma_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan Angka Random : ");
            int angka = int.Parse(Console.ReadLine());

            if (angka >= 100 )
            {
                Console.WriteLine("Angka Lebih Dari 100 !");
            }
            else if (angka <= 100 ) 
            {
                Console.WriteLine("Angka Tidak Valid!");
            }
            Console.ReadLine();
          





        }
    }
}

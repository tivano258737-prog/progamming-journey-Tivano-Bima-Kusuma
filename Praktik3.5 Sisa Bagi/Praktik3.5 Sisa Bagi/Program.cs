using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik3._5_Sisa_Bagi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan angka pertama: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukam angka kedua: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Sisa Bagi: " + (a % b));

            Console.Write(" Masukan angka ketiga: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Masukan angka keempat ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Hasil Bagi:  " + (c % d));
            Console.ReadLine();



        }
    }
}

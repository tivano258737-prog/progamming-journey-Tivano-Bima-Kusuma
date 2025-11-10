using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tivano3._2Pengurangan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Masukan angka pertama : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Masukan angka kedua : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Hasil pengurangan: " + (a - b));

            Console.Write(" Masukan angka ketiga : ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Masukan angka keempat : ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Hasil pengurangan: " + (c - d));
            Console.ReadLine();
        




        }
    }
}

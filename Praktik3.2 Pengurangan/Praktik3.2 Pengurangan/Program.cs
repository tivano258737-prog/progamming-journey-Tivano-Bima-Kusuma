using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik3._2_Pengurangan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka pertama: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan angka kedua: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hasil pengurangan: " + (a - b));

            Console.Write("Masukkan angka ketiga: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan angka keempat: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hasil pengurangan (double): " + (c - d));
            Console.ReadLine();







        }
    }
}

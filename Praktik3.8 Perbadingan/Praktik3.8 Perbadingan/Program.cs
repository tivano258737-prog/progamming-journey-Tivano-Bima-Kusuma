using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik3._8_Perbadingan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Operator Perbandingan ===");

            Console.Write(" Masukan angka pertama: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Masukan angka kedua: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" \nHasil Perbandingan: ");
            Console.WriteLine($"{a} == {b}  : " + (a == b));
            Console.WriteLine($"{a} != {b}  : " + (a != b));
            Console.WriteLine($"{a} > {b}   : " + (a  > b));
            Console.WriteLine($"{a} < {b}   : " + (a  < b));
            Console.WriteLine($"{a} >= {b}  : " + (a >= b));
            Console.WriteLine($"{a} <= {b}  : " + (a <= b));
        }
    }
}

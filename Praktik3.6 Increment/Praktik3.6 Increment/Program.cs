using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik3._6_Increment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Masukan angka: ");
            int x = Convert.ToInt32(Console.ReadLine());
            x++;
            Console.WriteLine(" Setelah x++ : " + x);

            Console.Write(" Masukan angka lain: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Nilai awal: " + y);
            Console.WriteLine(" Nilai ++y: " + (++y));
            Console.ReadLine();



        }
    }
}

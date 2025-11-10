using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik3._10_Penugasan
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("=== Progam Operator Penugasan ===");

            Console.Write(" Masukan nilai awal x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHasil Operasi Penugasan: ");
            Console.WriteLine(" Nilai awal x = " + x);

            x += 5;
            Console.WriteLine(" Setelah x += 5 → " + x);

            x -= 2;
            Console.WriteLine(" Setelah x -= 2 → " + x);

            x *= 3;
            Console.WriteLine(" Setelah x *= 3 → " + x);

            x /= 4;
            Console.WriteLine(" Setelah x /= 4 → " + x);

            x %= 3;
            Console.WriteLine(" Setelah x %= 3 → " + x);        }
    }
}

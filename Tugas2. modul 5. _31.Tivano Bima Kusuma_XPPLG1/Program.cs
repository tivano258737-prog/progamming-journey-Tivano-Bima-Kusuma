using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas2.modul_5._31.Tivano_Bima_Kusuma_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int i = 1;

            while (i <= 5)
            {
                total += i;
                i++;
            }
            Console.WriteLine($"Total = {total}");
            Console.ReadLine();
        }
    }
}

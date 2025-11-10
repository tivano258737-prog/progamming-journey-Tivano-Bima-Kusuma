using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik4._5_31.Tivano_Bima_Kusuma_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan umur anda: ");
            int umur = int.Parse(Console.ReadLine());

            if ( umur >= 17)
            {
                Console.WriteLine("Anda sudah dewaasa. ");
            }
            else
            {
                Console.WriteLine("Anda masih anak anak.");
            }

            Console.ReadLine();




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik5._3_31.Tivano_Bima_Kusuma_XPPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputUser = "";

            Console.WriteLine("Program akan terus berjalan hingga Anda mengetik 'keluar'.");
            while (inputUser.ToLower() != "keluar")
            {
                Console.Write("\nKetik sesuatu (atau 'keluar' untuk berhenti): ");
                inputUser = Console.ReadLine();

                Console.WriteLine("Anda mengetik: " + inputUser);
            }
            Console.WriteLine("\nProgram selesai. Terima Kasih!");
        }
    
    }
}

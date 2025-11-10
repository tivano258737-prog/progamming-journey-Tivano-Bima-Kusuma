using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NILAI_TUKAR_RUPIAH_31.Tivano_Bima_Kusuma_XPPLG11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kursUSD = 15000;   // 1 USD = 15,000 IDR
            double kursGBP = 20000;   // 1 GBP = 20,000 IDR
            double kursJPY = 110;     // 1 JPY = 110 IDR
            double kursSAR = 4000;    // 1 SAR = 4,000 IDR

            Console.Write("Masukkan jumlah Rupiah (IDR): ");
            double rupiah = Convert.ToDouble(Console.ReadLine());

            double dolar = rupiah / kursUSD;
            double poundsterling = rupiah / kursGBP;
            double yen = rupiah / kursJPY;
            double riyal = rupiah / kursSAR;

            Console.WriteLine("\nHasil konversi:");
            Console.WriteLine($"Dolar Amerika (USD): {dolar:F2} USD");
            Console.WriteLine($"Poundsterling Inggris (GBP): {poundsterling:F2} GBP");
            Console.WriteLine($"Yen Jepang (JPY): {yen:F2} JPY");
            Console.WriteLine($"Riyal Saudi (SAR): {riyal:F2} SAR");

            Console.ReadKey();







        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS_PRAKTIK._1_TivanoBimaKusuma_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input 3 bilangan
            Console.Write("Masukkan bilangan pertama: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan bilangan kedua  : ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan bilangan ketiga : ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Operasi Matematika
            double penjumlahan = a + b + c;
            double pengurangan = a - b - c;
            double perkalian = a * b * c;
            double pembagian = a / b / c; // dibagi berurutan: (a ÷ b) ÷ c

            // Hasil
            Console.WriteLine("\n=== HASIL PERHITUNGAN ===");
            Console.WriteLine($"Penjumlahan : {a} + {b} + {c} = {penjumlahan}");
            Console.WriteLine($"Pengurangan : {a} - {b} - {c} = {pengurangan}");
            Console.WriteLine($"Perkalian   : {a} x {b} x {c} = {perkalian}");
            Console.WriteLine($"Pembagian   : ({a} ÷ {b}) ÷ {c} = {pembagian}");

            Console.WriteLine("\nTekan ENTER untuk keluar...");
            Console.ReadLine();









        }
    }
}

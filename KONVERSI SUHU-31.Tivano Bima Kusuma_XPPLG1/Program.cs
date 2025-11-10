using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KONVERSI_SUHU_31.Tivano_Bima_Kusuma_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan suhu dalam Celcius: ");
            double celcius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celcius * 9 / 5) + 32;
            double reamur = celcius * 4 / 5;
            Console.WriteLine("\n---hasil konverensi---");
            Console.WriteLine($"Suhu dalam Fahrenheit: {fahrenheit} °F");
            Console.WriteLine($"Suhu dalam Reamur: {reamur} °R");
            Console.ReadKey();










        }
    }
}

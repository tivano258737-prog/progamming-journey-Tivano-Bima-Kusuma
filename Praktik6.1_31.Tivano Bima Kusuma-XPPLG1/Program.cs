using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._1_31.Tivano_Bima_Kusuma_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] siswa = new string[5];

            siswa[0] = "Adit Izin Serius";
            siswa[1] = "Roichan El Tahu";
            siswa[2] = "Iqbal Kopling";
            siswa[3] = "Erik Mping Limpung";
            siswa[4] = "Fayakun Imut";

            Console.WriteLine("DAFTAR NAMA SISWA :");
            Console.WriteLine("siswa ke-1 : " + siswa[0]);
            Console.WriteLine("siswa ke-2 : " + siswa[1]);
            Console.WriteLine("siswa ke-3 : " + siswa[2]);
            Console.WriteLine("siswa ke-4 : " + siswa[3]);
            Console.WriteLine("siswa ke-5 : " + siswa[4]);
        }
    }
}

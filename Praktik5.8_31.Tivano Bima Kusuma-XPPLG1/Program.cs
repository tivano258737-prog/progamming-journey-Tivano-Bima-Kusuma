using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik5._8_31.Tivano_Bima_Kusuma_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangiPilihan;

            do
            {
                // --- Blok Proses yang akan diulangi ---
                Console.WriteLine("-----------------------");
                Console.Write(" Masukan nama Anda : ");
                string nama = Console.ReadLine();
                Console.WriteLine($"Hallo, {nama} ! Proses telah selesai. ");
                //------------------------------
                // Pertanyaan untuk mengulang 
                Console.Write(" Apakah anda ingin mengulang lagi? (ya/tidak) :  ");
                ulangiPilihan = Console.ReadLine().ToLower(); // mengambil input dan mengubah ke huruf kecil

                Console.WriteLine(); // Baris kosong untuk kerapian

                // kondisi diperiksa di akhir : Ulangi selama pengguna mengetik "ya"
            } while (ulangiPilihan == "ya");
            Console.WriteLine(" Terimakasih. Program selesai.");
            Console.ReadLine();
        }
    }
}

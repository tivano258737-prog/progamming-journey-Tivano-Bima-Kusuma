using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace Project_Akhir_Reall_31.Tivano_Bima_Kusuma
{

    public partial class button3 : Form
    {
        // Variabel untuk menyimpan hasil perhitungan
        private decimal totalHarga = 0;
        private decimal potonganHarga = 0;
        private decimal totalBayar = 0;
        private decimal grandTotal = 0;


        public button3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jm.Items.Add("Makanan");
            jm.Items.Add("Minuman");
            nm.Items.Clear();
        }

        private void jm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jm.Text == "Makanan")
            {
                nm.SelectedIndexChanged -= nm_SelectedIndexChanged;
                nm.Items.Clear();
                nm.Text = "";
                nm.Items.Add("Nasi Goreng");
                nm.Items.Add("Nasi Ayam Geprek");
                nm.Items.Add("Nasi Ayam Bakar");
                nm.Items.Add("Mie Ayam");
                nm.SelectedIndexChanged += nm_SelectedIndexChanged;
            }

            else if (jm.Text == "Minuman")
            {
                nm.SelectedIndexChanged -= nm_SelectedIndexChanged;
                nm.Items.Clear();
                nm.Text = "";
                nm.Items.Add("Es Teh");
                nm.Items.Add("Es Jeruk");
                nm.Items.Add("Es Milo");
                nm.Items.Add("Air Putih");
                nm.SelectedIndexChanged += nm_SelectedIndexChanged;
            }
        }

        private void nm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nm.Text == "Nasi Goreng")
                harga.Text = "13000";

            else if (nm.Text == "Nasi Ayam Geprek")
                harga.Text = "14000";

            else if (nm.Text == "Nasi Ayam Bakar")
                harga.Text = "15000";

            else if (nm.Text == "Mie Ayam")
                harga.Text = "10000";

            else if (nm.Text == "Es Teh")
                harga.Text = "3000";

            else if (nm.Text == "Es Jeruk")
                harga.Text = "5000";

            else if (nm.Text == "Es Milo")
                harga.Text = "8000";

            else if (nm.Text == "Air Putih")
                harga.Text = "4000";

            // Hitung total setelah harga berubah
            HitungTotal();
        }

        // Method untuk menghitung total, diskon, dan total bayar
        private void HitungTotal()
        {
            try
            {
                // Ambil harga
                decimal hargaSatuan = 0;
                decimal.TryParse(harga.Text, out hargaSatuan);

                // Ambil jumlah
                int jml = 0;
                int.TryParse(jumlah.Text, out jml);

                // Hitung total harga
                totalHarga = hargaSatuan * jml;

                // Hitung diskon
                if (totalHarga >= 50000)
                    potonganHarga = 10000;
                else
                    potonganHarga = 0;

                // Hitung total bayar
                totalBayar = totalHarga - potonganHarga;

                // Tampilkan hasil
                th.Text = totalHarga.ToString("N0");
                disk.Text = potonganHarga.ToString("N0");
                tb.Text = totalBayar.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Event saat jumlah berubah
        private void jumlah_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        // Tombol PESAN (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            // Validasi
            if (string.IsNullOrEmpty(nm.Text))
            {
                MessageBox.Show("Mohon isi No Nota!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(jm.Text))
            {
                MessageBox.Show("Mohon pilih Jenis Menu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(nm.Text))
            {
                MessageBox.Show("Mohon pilih Nama Makanan/Minuman!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(jumlah.Text) || jumlah.Text == "0")
            {
                MessageBox.Show("Mohon isi Jumlah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hitung total
            HitungTotal();

            // Tampilkan konfirmasi
            string pesan = "=== DETAIL PESANAN ===\n\n" +
             $"No Nota: {nno.Text}\n" +
             $"Jenis: {jm.Text}\n" +
             $"Menu: {nm.Text}\n" +
             $"Harga: Rp {harga.Text}\n" +
             $"Jumlah: {jumlah.Text}\n\n" +
             "-------------------------\n" +
             $"Total Harga: Rp {totalHarga:N0}\n" +
             $"Diskon: Rp {potonganHarga:N0}\n" +
             "-------------------------\n" +
             $"TOTAL BAYAR: Rp {totalBayar:N0}";

            MessageBox.Show(pesan, "Konfirmasi Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Tombol BERSIH (button2)
        private void
            bton2_Click(object sender, EventArgs e)
        {
            nm.Text = "";
            jm.Text = "";
            nm.Items.Clear();
            nm.Text = "";
            harga.Text = "";
            jumlah.Text = "";
            th.Text = "";
            disk.Text = "";
            tb.Text = "";

            totalHarga = 0;
            potonganHarga = 0;
            totalBayar = 0;
        }

        private void bton2_Click_1(object sender, EventArgs e)
        {
            nm.Text = "";
            jm.Text = "";
            nm.Items.Clear();
            nm.Text = "";
            harga.Text = "";
            jumlah.Text = "";
            th.Text = "";
            disk.Text = "";
            tb.Text = "";

            totalHarga = 0;
            potonganHarga = 0;
            totalBayar = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
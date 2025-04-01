using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Memanggil InitializeComponent untuk inisialisasi komponen
        }

        // Event handler saat form dimuat
        private void Form1_Load(object sender, EventArgs e)
        {
            // Anda bisa menambahkan logic saat form pertama kali dimuat
        }

        // Event handler untuk tombol tambah buku
        private void TambahButton_Click(object sender, EventArgs e)
        {
            string namaBuku = namaBukuTextBox.Text.Trim();
            if (string.IsNullOrEmpty(namaBuku))
            {
                MessageBox.Show("Masukkan nama buku yang ingin dipinjam.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Menambahkan buku ke daftar buku
            daftarBukuListBox.Items.Add(namaBuku + " - " + tanggalPinjamPicker.Value.ToShortDateString());
            namaBukuTextBox.Clear(); // Mengosongkan input teks
        }

        // Event handler untuk tombol kembalikan buku
        private void KembalikanButton_Click(object sender, EventArgs e)
        {
            if (daftarBukuListBox.SelectedItem != null)
            {
                daftarBukuListBox.Items.Remove(daftarBukuListBox.SelectedItem); // Menghapus buku yang dipilih
            }
            else
            {
                MessageBox.Show("Pilih buku yang ingin dikembalikan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

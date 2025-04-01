namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Form yang dipanggil saat selesai melakukan cleanup dan disposing
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Method untuk mendesain dan menginisialisasi komponen-komponen dalam form
        private void InitializeComponent()
        {
            this.tambahButton = new System.Windows.Forms.Button();
            this.kembalikanButton = new System.Windows.Forms.Button();
            this.namaBukuTextBox = new System.Windows.Forms.TextBox();
            this.tanggalPinjamPicker = new System.Windows.Forms.DateTimePicker();
            this.daftarBukuListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tambahButton
            // 
            this.tambahButton.Location = new System.Drawing.Point(100, 100);
            this.tambahButton.Name = "tambahButton";
            this.tambahButton.Size = new System.Drawing.Size(100, 40);
            this.tambahButton.TabIndex = 0;
            this.tambahButton.Text = "Tambah Buku";
            this.tambahButton.UseVisualStyleBackColor = true;
            this.tambahButton.Click += new System.EventHandler(this.TambahButton_Click);
            // 
            // kembalikanButton
            // 
            this.kembalikanButton.Location = new System.Drawing.Point(220, 100);
            this.kembalikanButton.Name = "kembalikanButton";
            this.kembalikanButton.Size = new System.Drawing.Size(120, 40);
            this.kembalikanButton.TabIndex = 1;
            this.kembalikanButton.Text = "Kembalikan Buku";
            this.kembalikanButton.UseVisualStyleBackColor = true;
            this.kembalikanButton.Click += new System.EventHandler(this.KembalikanButton_Click);
            // 
            // namaBukuTextBox
            // 
            this.namaBukuTextBox.Location = new System.Drawing.Point(100, 20);
            this.namaBukuTextBox.Name = "namaBukuTextBox";
            this.namaBukuTextBox.Size = new System.Drawing.Size(200, 27);
            this.namaBukuTextBox.TabIndex = 2;
            // 
            // tanggalPinjamPicker
            // 
            this.tanggalPinjamPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tanggalPinjamPicker.Location = new System.Drawing.Point(100, 60);
            this.tanggalPinjamPicker.Name = "tanggalPinjamPicker";
            this.tanggalPinjamPicker.Size = new System.Drawing.Size(200, 27);
            this.tanggalPinjamPicker.TabIndex = 3;
            // 
            // daftarBukuListBox
            // 
            this.daftarBukuListBox.FormattingEnabled = true;
            this.daftarBukuListBox.ItemHeight = 20;
            this.daftarBukuListBox.Location = new System.Drawing.Point(20, 150);
            this.daftarBukuListBox.Name = "daftarBukuListBox";
            this.daftarBukuListBox.Size = new System.Drawing.Size(350, 100);
            this.daftarBukuListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.daftarBukuListBox);
            this.Controls.Add(this.tanggalPinjamPicker);
            this.Controls.Add(this.namaBukuTextBox);
            this.Controls.Add(this.kembalikanButton);
            this.Controls.Add(this.tambahButton);
            this.Name = "Form1";
            this.Text = "Peminjaman Buku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button tambahButton;
        private System.Windows.Forms.Button kembalikanButton;
        private System.Windows.Forms.TextBox namaBukuTextBox;
        private System.Windows.Forms.DateTimePicker tanggalPinjamPicker;
        private System.Windows.Forms.ListBox daftarBukuListBox;
    }
}

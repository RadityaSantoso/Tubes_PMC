using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class TambahRiwayat : Form
    {
        // Define the path to the CSV file
        private string csvFilePath = "Cleanedriwayatpasien.csv";

        public TambahRiwayat()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Get input values from text boxes
            string tanggal = txtTanggal.Text.Trim();
            string idPasien = txtIDPasien.Text.Trim();
            string diagnosis = txtDiagnosis.Text.Trim();
            string tindakan = txtTindakan.Text.Trim();
            string kontrol = txtKontrol.Text.Trim();
            string biaya = txtBiaya.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(tanggal) || string.IsNullOrEmpty(idPasien) ||
                string.IsNullOrEmpty(diagnosis) || string.IsNullOrEmpty(tindakan) ||
                string.IsNullOrEmpty(kontrol) || string.IsNullOrEmpty(biaya))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Format the new record
            string newRecord = $"{GetNextNo()},{tanggal},{idPasien},{diagnosis},{tindakan},{kontrol},{biaya}";

            try
            {
                // Append the new record to the CSV file
                using (StreamWriter sw = File.AppendText(csvFilePath))
                {
                    sw.WriteLine(newRecord);
                }

                // Show success message
                MessageBox.Show("Riwayat pasien berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear input fields after adding
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to get the next available No
        private int GetNextNo()
        {
            try
            {
                // Read all lines from the CSV file
                string[] lines = File.ReadAllLines(csvFilePath);

                // Return the number of existing records + 1
                return lines.Length + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1; // Start from No. 1 if there's an error
            }
        }

        // Method to clear input fields
        private void ClearInputFields()
        {
            txtTanggal.Clear();
            txtIDPasien.Clear();
            txtDiagnosis.Clear();
            txtTindakan.Clear();
            txtKontrol.Clear();
            txtBiaya.Clear();
        }

        private void txtBiaya_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKontrol_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var back = new opsi2();
            back.Show();
            this.Hide();
        }

        private void txtTanggal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

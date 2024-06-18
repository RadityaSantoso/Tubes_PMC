using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class tambahpasien : Form
    {
        // Define the path to the CSV file
        private string csvFilePath = "Cleanedriwayatpasien.csv";

        public tambahpasien()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Gather input data from text boxes
            string namaLengkap = txtNamaLengkap.Text.Trim();
            string alamat = txtAlamat.Text.Trim();
            string kota = txtKota.Text.Trim();
            string tempatLahir = txtTempatLahir.Text.Trim();
            string tanggalLahir = txtTanggalLahir.Text.Trim();
            string umur = txtUmur.Text.Trim();
            string noBPJS = txtNoBPJS.Text.Trim();
            string idPasien = txtIDPasien.Text.Trim();

            // Validate input (you can add more specific validations as needed)
            if (string.IsNullOrEmpty(namaLengkap) || string.IsNullOrEmpty(alamat) || string.IsNullOrEmpty(kota) ||
                string.IsNullOrEmpty(tempatLahir) || string.IsNullOrEmpty(tanggalLahir) || string.IsNullOrEmpty(umur) ||
                string.IsNullOrEmpty(noBPJS) || string.IsNullOrEmpty(idPasien))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Append the new patient data to the CSV file
                using (StreamWriter sw = File.AppendText(csvFilePath))
                {
                    // Generate the new row in CSV format
                    string newLine = $"{GetNextNo()}, {namaLengkap}, {alamat}, {kota}, {tempatLahir}, {tanggalLahir}, {umur}, {noBPJS}, {idPasien}";

                    // Write the new row to the CSV file
                    sw.WriteLine(newLine);
                }

                MessageBox.Show("Data pasien berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear input fields after successful addition
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetNextNo()
        {
            // Read the CSV file to find the next available "No" value
            int nextNo = 1; // Default starting number

            try
            {
                // Read all lines from the CSV file
                string[] lines = File.ReadAllLines(csvFilePath);

                // If there are existing lines, find the highest "No" and increment it
                if (lines.Length > 0)
                {
                    nextNo = lines.Length + 1; // Increment based on the current number of lines
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading CSV file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nextNo;
        }

        private void ClearInputFields()
        {
            // Clear all input fields
            txtNamaLengkap.Clear();
            txtAlamat.Clear();
            txtKota.Clear();
            txtTempatLahir.Clear();
            txtTanggalLahir.Clear();
            txtUmur.Clear();
            txtNoBPJS.Clear();
            txtIDPasien.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var back = new opsi_1();
            back.Show();
            this.Hide();
        }

        private void txtNamaLengkap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

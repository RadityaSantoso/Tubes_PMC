using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class UbahRiwayat : Form
    {
        // Define the path to the CSV file
        private string csvFilePath = "Cleanedriwayatpasien.csv";

        public UbahRiwayat()
        {
            InitializeComponent();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            // Get input values from text boxes
            string no = txtNo.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(no))
            {
                MessageBox.Show("Please enter the No. of the record to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Read all lines from the CSV file
                string[] lines = File.ReadAllLines(csvFilePath);

                // Find the record to update based on the No
                bool found = false;
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length >= 7 && parts[0] == no)
                    {
                        // Remove the record from the CSV file
                        string removedRecord = lines[i];
                        lines[i] = "";

                        // Write the updated lines back to the CSV file
                        File.WriteAllLines(csvFilePath, lines);

                        found = true;

                        // Show success message
                        MessageBox.Show("Riwayat pasien berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear input fields after updating
                        ClearInputFields();
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show($"No. {no} not found in the records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to clear input fields
        private void ClearInputFields()
        {
            txtNo.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var back = new opsi2();
            back.Show();
            this.Hide();
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

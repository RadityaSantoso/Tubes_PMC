using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class HapusRiwayat : Form
    {
        // Define the path to the CSV file
        private string csvFilePath = "Cleanedriwayatpasien.csv";

        public HapusRiwayat()
        {
            InitializeComponent();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Get the ID Pasien from the text box
            string idPasienToDelete = txtIDPasien.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(idPasienToDelete))
            {
                MessageBox.Show("Please enter ID Pasien.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Read all lines from the CSV file
                string[] lines = File.ReadAllLines(csvFilePath);

                // Flag to check if patient history was found and deleted
                bool foundAndDeleted = false;

                // Create a new StringWriter to write updated content
                using (StringWriter sw = new StringWriter())
                {
                    foreach (string line in lines)
                    {
                        // Split the line by comma to get each field
                        string[] fields = line.Split(',');

                        // Check if ID Pasien matches
                        if (fields.Length >= 3 && fields[2].Trim() == idPasienToDelete)
                        {
                            // Skip writing this line (effectively "deleting" it)
                            foundAndDeleted = true;
                            continue;
                        }

                        // Write the line to the StringWriter
                        sw.WriteLine(line);
                    }

                    // Write the updated content back to the CSV file
                    File.WriteAllText(csvFilePath, sw.ToString());
                }

                // Show success message if patient history was found and deleted
                if (foundAndDeleted)
                {
                    MessageBox.Show("Riwayat pasien berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ID Pasien tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Clear input field after deletion
                txtIDPasien.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var main = new main();
            main.Show();
            this.Hide();

        }

        private void txtIDPasien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

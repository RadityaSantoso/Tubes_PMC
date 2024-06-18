using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class hapus : Form
    {
        // Define the path to the embedded CSV file
        private string csvFilePath = "Cleanedpasien.csv";

        public hapus()
        {
            InitializeComponent();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string idToDelete = txtIDPasien.Text.Trim();

            // Check if ID is provided
            if (string.IsNullOrEmpty(idToDelete))
            {
                MessageBox.Show("Please enter ID Pasien to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Read the CSV file into a DataTable
                DataTable dt = new DataTable();
                using (StreamReader sr = new StreamReader(csvFilePath))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dt.Columns.Add(header);
                    }

                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dr[i] = rows[i];
                        }
                        dt.Rows.Add(dr);
                    }
                }

                // Search for the row with the specified ID Pasien
                DataRow rowToDelete = dt.AsEnumerable().FirstOrDefault(row => row.Field<string>("ID Pasien") == idToDelete);

                if (rowToDelete != null)
                {
                    // Delete the row from DataTable
                    dt.Rows.Remove(rowToDelete);

                    // Rewrite the CSV file
                    using (StreamWriter sw = new StreamWriter(csvFilePath))
                    {
                        // Write headers
                        sw.WriteLine(string.Join(",", dt.Columns.Cast<DataColumn>().Select(dc => dc.ColumnName)));

                        // Write data
                        foreach (DataRow row in dt.Rows)
                        {
                            object[] array = row.ItemArray;
                            sw.WriteLine(string.Join(",", array));
                        }
                    }

                    MessageBox.Show("Pasien berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var tambah = new tambahpasien(); // Create an instance of tambahpasien form
                    tambah.Show(); // Show the tambahpasien form
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ID Pasien tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var back = new opsi_1();
            back.Show();
            this.Hide();
        }

        private void txtIDPasien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class opsi3 : Form
    {
        private DataTable patientsTable;
        private DataTable treatmentsTable;

        public opsi3()
        {
            InitializeComponent();
            LoadCsvFiles(); // Load CSV files on form load
        }

        private void LoadCsvFiles()
        {
            string patientsFilePath = "Cleanedpasien.csv";
            string treatmentsFilePath = "Cleanedriwayatpasien.csv";

            patientsTable = ReadCsv(patientsFilePath);
            treatmentsTable = ReadCsv(treatmentsFilePath);
        }

        private DataTable ReadCsv(string filePath)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header.Trim('"')); // Trim quotes from headers
                    }

                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dataRow[i] = rows[i].Trim('"'); // Trim quotes from values
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading CSV file: " + ex.Message);
            }

            return dataTable;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string patientId = textBoxPatientId.Text.Trim();
            if (string.IsNullOrEmpty(patientId))
            {
                MessageBox.Show("Please enter a patient ID.");
                return;
            }

            DataRow patientRow = FindPatient(patientId);
            if (patientRow == null)
            {
                MessageBox.Show("Patient with ID " + patientId + " not found.");
                return;
            }

            DataRow[] treatmentRows = FindTreatments(patientId);

            StringBuilder message = new StringBuilder();
            message.AppendLine("Patient Information:");
            message.AppendLine("No: " + patientRow["No"]);
            message.AppendLine("Nama Lengkap: " + patientRow["Nama Lengkap"]);
            message.AppendLine("Alamat: " + patientRow["Alamat"]);
            message.AppendLine("Kota: " + patientRow["Kota"]);
            message.AppendLine("Tempat Lahir: " + patientRow["Tempat Lahir"]);
            message.AppendLine("Tanggal Lahir: " + patientRow["Tanggal Lahir"]);
            message.AppendLine("Umur (th): " + patientRow["Umur (th)"]);
            message.AppendLine("No BPJS: " + patientRow["No BPJS"]);
            message.AppendLine("ID Pasien: " + patientRow["ID Pasien"]);

            message.AppendLine();
            message.AppendLine("Treatment Information:");
            foreach (DataRow row in treatmentRows)
            {
                message.AppendLine("Tanggal: " + row["Tanggal"]);
                message.AppendLine("Diagnosis: " + row["Diagnosis"]);
                message.AppendLine("Tindakan: " + row["Tindakan"]);
                message.AppendLine("Kontrol: " + row["Kontrol"]);
                message.AppendLine("Biaya (Rp): " + row["Biaya (Rp)"]);
                message.AppendLine();
            }

            MessageBox.Show(message.ToString(), "Patient Details");
        }

        private DataRow FindPatient(string patientId)
        {
            return patientsTable.AsEnumerable()
                                .FirstOrDefault(row => row.Field<string>("ID Pasien") == patientId);
        }

        private DataRow[] FindTreatments(string patientId)
        {
            return treatmentsTable.AsEnumerable()
                                  .Where(row => row.Field<string>("ID Pasien") == patientId)
                                  .ToArray();
        }

        private void opsi3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var main = new main();
            main.Show();
            this.Hide();
        }

        private void textBoxPatientId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

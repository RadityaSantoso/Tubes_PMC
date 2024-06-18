using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class opsi5 : Form
    {
        public opsi5()
        {
            InitializeComponent();
            DisplayPatientAndDiseaseData();
        }

        private void DisplayPatientAndDiseaseData()
        {
            string filePath = "Cleanedriwayatpasien.csv";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found!");
                return;
            }

            var yearData = new YearData();

            using (var reader = new StreamReader(filePath))
            {
                string line;
                // Skip the header
                reader.ReadLine();

                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');

                    if (values.Length < 7)
                        continue;

                    var tanggal = values[1];
                    var idPasien = values[2];
                    var diagnosis = values[3];
                    var tindakan = values[4];
                    var kontrol = values[5];
                    var biaya = int.Parse(values[6]); // Assuming Biaya (Rp) is an integer

                    int day, month, year;

                    var dateParts = tanggal.Split('-');
                    day = int.Parse(dateParts[2]); // Adjusted for YYYY-MM-DD format
                    month = int.Parse(dateParts[1]);
                    year = int.Parse(dateParts[0]);

                    yearData.AddPatientData(year, month, diagnosis, tindakan, kontrol, biaya);
                }
            }

            richTextBoxData.Text = yearData.GetFormattedData();
        }

        private int MonthToNumber(string month)
        {
            switch (month.ToLower())
            {
                case "januari": case "jan": return 1;
                case "februari": case "feb": return 2;
                case "maret": case "mar": return 3;
                case "april": case "apr": return 4;
                case "mei": return 5;
                case "juni": case "jun": return 6;
                case "juli": case "jul": return 7;
                case "agustus": case "agu": return 8;
                case "september": case "sep": return 9;
                case "oktober": case "okt": return 10;
                case "november": case "nov": return 11;
                case "desember": case "des": return 12;
                default: throw new ArgumentException("Invalid month");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var main = new main();
            main.Show();
            this.Hide();
        }

        private void richTextBoxData_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Disease
    {
        public string Nama { get; set; }
        public int Jumlah { get; set; }

        public Disease(string nama)
        {
            Nama = nama;
            Jumlah = 1;
        }
    }

    public class YearData
    {
        private readonly Dictionary<int, Year> years = new Dictionary<int, Year>();

        public void AddPatientData(int year, int month, string diagnosis, string tindakan, string kontrol, int biaya)
        {
            if (!years.ContainsKey(year))
            {
                years[year] = new Year(year);
            }

            years[year].AddDisease(month, diagnosis, tindakan, kontrol, biaya);
        }

        public string GetFormattedData()
        {
            var sb = new System.Text.StringBuilder();

            foreach (var year in years.Values.OrderBy(y => y.Tahun))
            {
                sb.AppendLine($"TAHUN {year.Tahun}");

                for (int i = 0; i < 12; i++)
                {
                    sb.AppendLine($"{NumberToMonth(i + 1)}  ({year.JumlahPasien[i]} pasien)");

                    foreach (var disease in year.Bulan[i].OrderByDescending(d => d.Jumlah))
                    {
                        sb.AppendLine($"   {disease.Nama} : {disease.Jumlah}");
                    }
                }
            }

            return sb.ToString();
        }

        private string NumberToMonth(int month)
        {
            switch (month)
            {
                case 1: return "Januari";
                case 2: return "Februari";
                case 3: return "Maret";
                case 4: return "April";
                case 5: return "Mei";
                case 6: return "Juni";
                case 7: return "Juli";
                case 8: return "Agustus";
                case 9: return "September";
                case 10: return "Oktober";
                case 11: return "November";
                case 12: return "Desember";
                default: return "Invalid month";
            }
        }
    }

    public class Year
    {
        public int Tahun { get; set; }
        public List<Disease>[] Bulan { get; set; }
        public int[] JumlahPasien { get; set; }

        public Year(int tahun)
        {
            Tahun = tahun;
            Bulan = new List<Disease>[12];
            JumlahPasien = new int[12];

            for (int i = 0; i < 12; i++)
            {
                Bulan[i] = new List<Disease>();
                JumlahPasien[i] = 0;
            }
        }

        public void AddDisease(int month, string diagnosis, string tindakan, string kontrol, int biaya)
        {
            month--; // Adjust month to zero-based index
            JumlahPasien[month]++;

            var existingDisease = Bulan[month].FirstOrDefault(d => d.Nama == diagnosis);

            if (existingDisease != null)
            {
                existingDisease.Jumlah++;
            }
            else
            {
                Bulan[month].Add(new Disease(diagnosis));
            }
        }
    }
}

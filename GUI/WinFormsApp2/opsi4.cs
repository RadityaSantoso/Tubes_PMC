using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class opsi4 : Form
    {
        public opsi4()
        {
            InitializeComponent();
            DisplayCosts();
        }

        private void DisplayCosts()
        {
            string filePath = "Cleanedriwayatpasien.csv";
            string[] lines = File.ReadAllLines(filePath);

            var costs = lines.Skip(1) // Skip header
                             .Select(line => line.Split(','))
                             .Select(cols => new
                             {
                                 Date = cols.Length > 1 && DateTime.TryParse(cols[1], out DateTime date) ? date : DateTime.MinValue,
                                 Cost = cols.Length > 6 ? decimal.Parse(cols[6]) : 0
                             });

            var monthlyCosts = costs.GroupBy(c => new { c.Date.Year, c.Date.Month })
                                    .Select(group => new
                                    {
                                        Year = group.Key.Year,
                                        Month = group.Key.Month,
                                        TotalCost = group.Sum(c => c.Cost),
                                        Count = group.Count()
                                    });

            var yearlyCosts = costs.GroupBy(c => c.Date.Year)
                                   .Select(group => new
                                   {
                                       Year = group.Key,
                                       TotalCost = group.Sum(c => c.Cost),
                                       Count = group.Count()
                                   });
            foreach (var year in yearlyCosts)
            {
                richTextBox1.Text += $"Year: {year.Year}\tTotal Revenue: {year.TotalCost:C}\tAverage Revenue: {(year.TotalCost / year.Count):C}\r\n\n";
            }

            foreach (var month in monthlyCosts)
            {
                richTextBox1.Text += $"Year: {month.Year}\tMonth: {new DateTime(month.Year, month.Month, 1).ToString("MMMM")}\t\tTotal Revenue: {month.TotalCost:C}\r\n";
            }

            richTextBox1.Text += "\r\n"; // Add a separator between monthly and yearly results


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var main = new main();
            main.Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

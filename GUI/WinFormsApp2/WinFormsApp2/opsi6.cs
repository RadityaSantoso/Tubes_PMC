using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class opsi6 : Form
    {
        private struct Riwayat
        {
            public int no;
            public string tanggal;
            public string id_pasien;
            public string diagnosis;
            public string tindakan;
            public string kontrol;
            public int biaya;
        }

        private class Node
        {
            public Riwayat data;
            public Node next;
        }

        private Node head;

        public opsi6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var main = new main();
            main.Show();
            this.Hide();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;
            int year = selectedDate.Year;
            int month = selectedDate.Month;
            int day = selectedDate.Day;

            string filePath = "Cleanedriwayatpasien.csv";

            if (LoadPatientRecords(filePath))
            {
                PrintPatientInfoByControlDate(day, month, year);
            }
            else
            {
                MessageBox.Show("Failed to load patient records from file.");
            }
        }

        private bool LoadPatientRecords(string filename)
        {
            head = null;  // Initialize head of linked list

            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line;  // Variable to store each line of the file

                    // Skip header line
                    sr.ReadLine();

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        // Ensure we have exactly 7 parts
                        if (parts.Length != 7)
                        {
                            continue;
                        }

                        // Parse each field
                        int no;
                        if (!int.TryParse(parts[0], out no))
                        {
                            MessageBox.Show($"Invalid 'No' value in line: {line}");
                            continue;
                        }

                        int biaya;
                        if (!int.TryParse(parts[6], out biaya))
                        {
                            MessageBox.Show($"Invalid 'Biaya' value in line: {line}");
                            continue;
                        }

                        // Create Riwayat record
                        Riwayat record = new Riwayat
                        {
                            no = no,
                            tanggal = parts[1],
                            id_pasien = parts[2],
                            diagnosis = parts[3],
                            tindakan = parts[4],
                            kontrol = parts[5],
                            biaya = biaya
                        };

                        // Create a new node for this record
                        Node newNode = new Node
                        {
                            data = record,
                            next = null
                        };

                        // Append the new node to the linked list
                        if (head == null)
                        {
                            head = newNode;
                        }
                        else
                        {
                            Node current = head;
                            while (current.next != null)
                            {
                                current = current.next;
                            }
                            current.next = newNode;
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patient records: {ex.Message}");
                return false;
            }
        }

        private void PrintPatientInfoByControlDate(int day, int month, int year)
        {
            Node current = head;
            bool found = false;

            while (current != null)
            {
                string[] controlDateParts = current.data.kontrol.Split('-');

                // Ensure we have exactly 3 parts for the control date
                if (controlDateParts.Length != 3)
                {
                    MessageBox.Show($"Invalid control date format: {current.data.kontrol}");
                    current = current.next;
                    continue;
                }

                int controlYear, controlMonth, controlDay;
                if (!int.TryParse(controlDateParts[0], out controlYear) ||
                    !int.TryParse(controlDateParts[1], out controlMonth) ||
                    !int.TryParse(controlDateParts[2], out controlDay))
                {
                    MessageBox.Show($"Invalid control date format: {current.data.kontrol}");
                    current = current.next;
                    continue;
                }

                // Compare dates
                if (controlYear == year && controlMonth == month && controlDay == day)
                {
                    string message = $"ID Pasien: {current.data.id_pasien}, Tindakan: {current.data.tindakan}, Diagnosis: {current.data.diagnosis}, Biaya: {current.data.biaya}";
                    MessageBox.Show(message);
                    found = true;
                }

                current = current.next;
            }

        }
    }
}

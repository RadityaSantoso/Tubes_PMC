using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class opsi_1 : Form
    {
        public opsi_1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tambah = new tambahpasien();
            tambah.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ubah = new ubahpasien();
            ubah.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var main = new main();
            main.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var hapus = new hapus();
            hapus.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cari = new opsi3();
            cari.Show();
            this.Hide();
        }
    }
}

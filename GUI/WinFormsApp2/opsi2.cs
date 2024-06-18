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
    public partial class opsi2 : Form
    {
        public opsi2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var main = new main();
            main.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cari = new opsi3();
            cari.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var hapus = new HapusRiwayat();
            hapus.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ubah = new UbahRiwayat();
            ubah.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tambah = new TambahRiwayat();
            tambah.Show();
            this.Hide();
        }
    }
}

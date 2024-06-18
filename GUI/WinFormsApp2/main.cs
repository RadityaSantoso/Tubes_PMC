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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var opsi1 = new opsi_1();
            opsi1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var opsi2 = new opsi2();
            opsi2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var opsi3 = new opsi3();
            opsi3.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var opsi4 = new opsi4();
            opsi4.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            var opsi5 = new opsi5();
            opsi5.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            var opsi6 = new opsi6();
            opsi6.Show();
            this.Hide();
        }


    }
}

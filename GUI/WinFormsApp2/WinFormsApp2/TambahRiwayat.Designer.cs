namespace WinFormsApp2
{
    partial class TambahRiwayat
    {
        private System.ComponentModel.IContainer components = null;

        // Controls declaration
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTanggal;
        private System.Windows.Forms.TextBox txtIDPasien;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.TextBox txtTindakan;
        private System.Windows.Forms.TextBox txtKontrol;
        private System.Windows.Forms.TextBox txtBiaya;
        private System.Windows.Forms.Button btnTambah;

        // Dispose method
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Initialize components method
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTanggal = new TextBox();
            txtIDPasien = new TextBox();
            txtDiagnosis = new TextBox();
            txtTindakan = new TextBox();
            txtKontrol = new TextBox();
            txtBiaya = new TextBox();
            btnTambah = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 40);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Tanggal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 80);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "ID Pasien:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 120);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Diagnosis:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 160);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Tindakan:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 200);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 4;
            label5.Text = "Kontrol:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 240);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 5;
            label6.Text = "Biaya:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(336, 240);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 6;
            label7.Text = "(Rp / IDR)";
            // 
            // txtTanggal
            // 
            txtTanggal.Location = new Point(171, 36);
            txtTanggal.Margin = new Padding(3, 4, 3, 4);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.Size = new Size(228, 27);
            txtTanggal.TabIndex = 7;
            txtTanggal.TextChanged += txtTanggal_TextChanged;
            // 
            // txtIDPasien
            // 
            txtIDPasien.Location = new Point(171, 76);
            txtIDPasien.Margin = new Padding(3, 4, 3, 4);
            txtIDPasien.Name = "txtIDPasien";
            txtIDPasien.Size = new Size(228, 27);
            txtIDPasien.TabIndex = 8;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(171, 116);
            txtDiagnosis.Margin = new Padding(3, 4, 3, 4);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(228, 27);
            txtDiagnosis.TabIndex = 9;
            // 
            // txtTindakan
            // 
            txtTindakan.Location = new Point(171, 156);
            txtTindakan.Margin = new Padding(3, 4, 3, 4);
            txtTindakan.Name = "txtTindakan";
            txtTindakan.Size = new Size(228, 27);
            txtTindakan.TabIndex = 10;
            // 
            // txtKontrol
            // 
            txtKontrol.Location = new Point(171, 197);
            txtKontrol.Margin = new Padding(3, 4, 3, 4);
            txtKontrol.Name = "txtKontrol";
            txtKontrol.Size = new Size(228, 27);
            txtKontrol.TabIndex = 15;
            txtKontrol.TextChanged += txtKontrol_TextChanged;
            // 
            // txtBiaya
            // 
            txtBiaya.Location = new Point(171, 237);
            txtBiaya.Margin = new Padding(3, 4, 3, 4);
            txtBiaya.Name = "txtBiaya";
            txtBiaya.Size = new Size(159, 27);
            txtBiaya.TabIndex = 14;
            txtBiaya.TextChanged += txtBiaya_TextChanged;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(112, 287);
            btnTambah.Margin = new Padding(3, 4, 3, 4);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(86, 31);
            btnTambah.TabIndex = 13;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // button1
            // 
            button1.Location = new Point(257, 289);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TambahRiwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 348);
            Controls.Add(button1);
            Controls.Add(btnTambah);
            Controls.Add(txtBiaya);
            Controls.Add(txtKontrol);
            Controls.Add(txtTindakan);
            Controls.Add(txtDiagnosis);
            Controls.Add(txtIDPasien);
            Controls.Add(txtTanggal);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TambahRiwayat";
            Text = "Tambah Riwayat Pasien";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
    }
}

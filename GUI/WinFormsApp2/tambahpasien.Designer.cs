namespace WinFormsApp2
{
    partial class tambahpasien
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNamaLengkap;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.TextBox txtTempatLahir;
        private System.Windows.Forms.TextBox txtTanggalLahir;
        private System.Windows.Forms.TextBox txtUmur;
        private System.Windows.Forms.TextBox txtNoBPJS;
        private System.Windows.Forms.TextBox txtIDPasien;
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
            label8 = new Label();
            txtNamaLengkap = new TextBox();
            txtAlamat = new TextBox();
            txtKota = new TextBox();
            txtTempatLahir = new TextBox();
            txtTanggalLahir = new TextBox();
            txtUmur = new TextBox();
            txtNoBPJS = new TextBox();
            txtIDPasien = new TextBox();
            btnTambah = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 40);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama Lengkap:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 80);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Alamat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 120);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Kota:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 160);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 3;
            label4.Text = "Tempat Lahir:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 200);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 4;
            label5.Text = "Tanggal Lahir:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 240);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 5;
            label6.Text = "Umur:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 280);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 6;
            label7.Text = "No BPJS:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 320);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 7;
            label8.Text = "ID Pasien:";
            // 
            // txtNamaLengkap
            // 
            txtNamaLengkap.Location = new Point(171, 36);
            txtNamaLengkap.Margin = new Padding(3, 4, 3, 4);
            txtNamaLengkap.Name = "txtNamaLengkap";
            txtNamaLengkap.Size = new Size(228, 27);
            txtNamaLengkap.TabIndex = 8;
            txtNamaLengkap.TextChanged += txtNamaLengkap_TextChanged;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(171, 76);
            txtAlamat.Margin = new Padding(3, 4, 3, 4);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(228, 27);
            txtAlamat.TabIndex = 9;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(171, 116);
            txtKota.Margin = new Padding(3, 4, 3, 4);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(228, 27);
            txtKota.TabIndex = 10;
            // 
            // txtTempatLahir
            // 
            txtTempatLahir.Location = new Point(171, 156);
            txtTempatLahir.Margin = new Padding(3, 4, 3, 4);
            txtTempatLahir.Name = "txtTempatLahir";
            txtTempatLahir.Size = new Size(228, 27);
            txtTempatLahir.TabIndex = 11;
            // 
            // txtTanggalLahir
            // 
            txtTanggalLahir.Location = new Point(171, 196);
            txtTanggalLahir.Margin = new Padding(3, 4, 3, 4);
            txtTanggalLahir.Name = "txtTanggalLahir";
            txtTanggalLahir.Size = new Size(228, 27);
            txtTanggalLahir.TabIndex = 12;
            // 
            // txtUmur
            // 
            txtUmur.Location = new Point(171, 236);
            txtUmur.Margin = new Padding(3, 4, 3, 4);
            txtUmur.Name = "txtUmur";
            txtUmur.Size = new Size(228, 27);
            txtUmur.TabIndex = 13;
            // 
            // txtNoBPJS
            // 
            txtNoBPJS.Location = new Point(171, 276);
            txtNoBPJS.Margin = new Padding(3, 4, 3, 4);
            txtNoBPJS.Name = "txtNoBPJS";
            txtNoBPJS.Size = new Size(228, 27);
            txtNoBPJS.TabIndex = 14;
            // 
            // txtIDPasien
            // 
            txtIDPasien.Location = new Point(171, 316);
            txtIDPasien.Margin = new Padding(3, 4, 3, 4);
            txtIDPasien.Name = "txtIDPasien";
            txtIDPasien.Size = new Size(228, 27);
            txtIDPasien.TabIndex = 15;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(85, 371);
            btnTambah.Margin = new Padding(3, 4, 3, 4);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(86, 31);
            btnTambah.TabIndex = 16;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // button1
            // 
            button1.Location = new Point(261, 372);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 17;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tambahpasien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 415);
            Controls.Add(button1);
            Controls.Add(btnTambah);
            Controls.Add(txtIDPasien);
            Controls.Add(txtNoBPJS);
            Controls.Add(txtUmur);
            Controls.Add(txtTanggalLahir);
            Controls.Add(txtTempatLahir);
            Controls.Add(txtKota);
            Controls.Add(txtAlamat);
            Controls.Add(txtNamaLengkap);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "tambahpasien";
            Text = "Tambah Pasien";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
    }
}

namespace WinFormsApp2
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(206, 29);
            label1.Name = "label1";
            label1.Size = new Size(232, 35);
            label1.TabIndex = 0;
            label1.Text = "Pilih Menu dibawah";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(55, 92);
            button1.Name = "button1";
            button1.Size = new Size(254, 100);
            button1.TabIndex = 1;
            button1.Text = "menambah, mengubah, menghapus dan mencari data pasien yang datang";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(335, 92);
            button2.Name = "button2";
            button2.Size = new Size(254, 100);
            button2.TabIndex = 2;
            button2.Text = "menambah, mengubah, menghapus dan mencari riwayat kedatangan diagnosis , dan tindakan kepada pasien";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(55, 219);
            button3.Name = "button3";
            button3.Size = new Size(254, 85);
            button3.TabIndex = 3;
            button3.Text = "Info pasien dan riwayat medis";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(335, 219);
            button4.Name = "button4";
            button4.Size = new Size(254, 85);
            button4.TabIndex = 4;
            button4.Text = "laporan pendapatan bulanan tahunan dan informasi rata rata per tahun ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(55, 324);
            button5.Name = "button5";
            button5.Size = new Size(254, 73);
            button5.TabIndex = 5;
            button5.Text = " info jumlah pasien dan penyakit yang di derita";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(335, 324);
            button6.Name = "button6";
            button6.Size = new Size(254, 73);
            button6.TabIndex = 6;
            button6.Text = " info kontrol pasien";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 431);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "main";
            Text = "main";
            Load += main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
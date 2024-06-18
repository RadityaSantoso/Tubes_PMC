namespace WinFormsApp2
{
    partial class hapus
    {
        private System.ComponentModel.IContainer components = null;

        // Controls declaration
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDPasien;
        private System.Windows.Forms.Button btnHapus;

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
            txtIDPasien = new TextBox();
            btnHapus = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 40);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Pasien:";
            // 
            // txtIDPasien
            // 
            txtIDPasien.Location = new Point(114, 36);
            txtIDPasien.Margin = new Padding(3, 4, 3, 4);
            txtIDPasien.Name = "txtIDPasien";
            txtIDPasien.Size = new Size(171, 27);
            txtIDPasien.TabIndex = 1;
            txtIDPasien.TextChanged += txtIDPasien_TextChanged;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(54, 93);
            btnHapus.Margin = new Padding(3, 4, 3, 4);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(86, 31);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // button1
            // 
            button1.Location = new Point(191, 94);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // hapus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 148);
            Controls.Add(button1);
            Controls.Add(btnHapus);
            Controls.Add(txtIDPasien);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "hapus";
            Text = "hapus";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
    }
}

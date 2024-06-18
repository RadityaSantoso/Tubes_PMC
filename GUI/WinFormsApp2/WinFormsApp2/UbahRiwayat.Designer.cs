namespace WinFormsApp2
{
    partial class UbahRiwayat
    {
        private System.ComponentModel.IContainer components = null;

        // Controls declaration
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Button btnUbah;

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
            txtNo = new TextBox();
            btnUbah = new Button();
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
            // txtNo
            // 
            txtNo.Location = new Point(112, 37);
            txtNo.Margin = new Padding(3, 4, 3, 4);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(228, 27);
            txtNo.TabIndex = 1;
            txtNo.TextChanged += txtNo_TextChanged;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(112, 92);
            btnUbah.Margin = new Padding(3, 4, 3, 4);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(86, 28);
            btnUbah.TabIndex = 2;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = true;
            btnUbah.Click += btnUbah_Click;
            // 
            // button1
            // 
            button1.Location = new Point(246, 92);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UbahRiwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 133);
            Controls.Add(button1);
            Controls.Add(btnUbah);
            Controls.Add(txtNo);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UbahRiwayat";
            Text = "Ubah Riwayat Pasien";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
    }
}

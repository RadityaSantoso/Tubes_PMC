namespace WinFormsApp2
{
    partial class opsi4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(13, 24);
            label1.Name = "label1";
            label1.Size = new Size(420, 35);
            label1.TabIndex = 1;
            label1.Text = "LAPORAN PENDAPATAN PER BULAN";
            // 
            // button1
            // 
            button1.Location = new Point(524, 24);
            button1.Name = "button1";
            button1.Size = new Size(110, 35);
            button1.TabIndex = 2;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(13, 89);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(638, 240);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // opsi4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 364);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "opsi4";
            Text = "Cost Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Button button1;
        private RichTextBox richTextBox1;
    }
}

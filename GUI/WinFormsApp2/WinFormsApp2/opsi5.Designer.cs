namespace WinFormsApp2
{
    partial class opsi5
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox richTextBoxData;

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
            richTextBoxData = new RichTextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // richTextBoxData
            // 
            richTextBoxData.Location = new Point(52, 108);
            richTextBoxData.Margin = new Padding(4, 5, 4, 5);
            richTextBoxData.Name = "richTextBoxData";
            richTextBoxData.Size = new Size(614, 304);
            richTextBoxData.TabIndex = 0;
            richTextBoxData.Text = "";
            richTextBoxData.TextChanged += richTextBoxData_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(572, 423);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(261, 43);
            label1.Name = "label1";
            label1.Size = new Size(167, 35);
            label1.TabIndex = 2;
            label1.Text = "Data penyakit";
            // 
            // opsi5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 463);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(richTextBoxData);
            Margin = new Padding(4, 5, 4, 5);
            Name = "opsi5";
            Text = "Patient and Disease Data";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Label label1;
    }
}

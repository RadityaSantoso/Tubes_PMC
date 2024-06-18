namespace WinFormsApp2
{
    partial class opsi2
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(268, 198);
            button4.Name = "button4";
            button4.Size = new Size(117, 68);
            button4.TabIndex = 9;
            button4.Text = "Mencari";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(48, 198);
            button3.Name = "button3";
            button3.Size = new Size(136, 68);
            button3.TabIndex = 8;
            button3.Text = "Menghapus";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(268, 97);
            button2.Name = "button2";
            button2.Size = new Size(117, 68);
            button2.TabIndex = 7;
            button2.Text = "Mengubah";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(48, 97);
            button1.Name = "button1";
            button1.Size = new Size(136, 68);
            button1.TabIndex = 6;
            button1.Text = "Menambah";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(110, 49);
            label1.Name = "label1";
            label1.Size = new Size(221, 35);
            label1.TabIndex = 5;
            label1.Text = "Pilih opsi dibawah:";
            label1.Click += label1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(307, 312);
            button5.Name = "button5";
            button5.Size = new Size(78, 29);
            button5.TabIndex = 10;
            button5.Text = "back";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // opsi2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 366);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "opsi2";
            Text = "opsi2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button5;
    }
}
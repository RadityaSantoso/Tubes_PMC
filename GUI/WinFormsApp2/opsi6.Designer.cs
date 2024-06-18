namespace WinFormsApp2
{
    partial class opsi6
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
            button1 = new Button();
            label2 = new Label();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(326, 363);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(58, 78);
            label2.Name = "label2";
            label2.Size = new Size(322, 28);
            label2.TabIndex = 3;
            label2.Text = "Masukkan tanggal yang ingin dicari";
            label2.Click += label2_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(91, 127);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // opsi6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 450);
            Controls.Add(monthCalendar1);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "opsi6";
            Text = "opsi6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private MonthCalendar monthCalendar1;
        private ListView listView1;
    }
}
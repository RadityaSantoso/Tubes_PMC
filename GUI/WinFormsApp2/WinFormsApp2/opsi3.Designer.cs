namespace WinFormsApp2
{
    partial class opsi3
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
            textBoxPatientId = new TextBox();
            buttonSearch = new Button();
            labelPatientId = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxPatientId
            // 
            textBoxPatientId.Location = new Point(148, 63);
            textBoxPatientId.Margin = new Padding(4, 5, 4, 5);
            textBoxPatientId.Name = "textBoxPatientId";
            textBoxPatientId.Size = new Size(199, 27);
            textBoxPatientId.TabIndex = 0;
            textBoxPatientId.TextChanged += textBoxPatientId_TextChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(356, 60);
            buttonSearch.Margin = new Padding(4, 5, 4, 5);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(100, 35);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelPatientId
            // 
            labelPatientId.AutoSize = true;
            labelPatientId.Location = new Point(43, 68);
            labelPatientId.Margin = new Padding(4, 0, 4, 0);
            labelPatientId.Name = "labelPatientId";
            labelPatientId.Size = new Size(76, 20);
            labelPatientId.TabIndex = 2;
            labelPatientId.Text = "ID Pasien :";
            // 
            // button1
            // 
            button1.Location = new Point(474, 62);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // opsi3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 159);
            Controls.Add(button1);
            Controls.Add(labelPatientId);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxPatientId);
            Margin = new Padding(4, 5, 4, 5);
            Name = "opsi3";
            Text = "Informasi Pasien";
            Load += opsi3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxPatientId;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelPatientId;
        private Button button1;
    }
}

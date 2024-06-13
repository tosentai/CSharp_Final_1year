namespace Final
{
    partial class Convert
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
            btnBrowseInput = new Button();
            txtInputFile = new TextBox();
            btnBrowseOutput = new Button();
            txtOuputFile = new TextBox();
            label1 = new Label();
            cmbOutputFormat = new ComboBox();
            label2 = new Label();
            txtOutputFileName = new TextBox();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // btnBrowseInput
            // 
            btnBrowseInput.Font = new Font("Impact", 14.25F);
            btnBrowseInput.Location = new Point(12, 12);
            btnBrowseInput.Name = "btnBrowseInput";
            btnBrowseInput.Size = new Size(313, 32);
            btnBrowseInput.TabIndex = 0;
            btnBrowseInput.Text = "Вибрати файл для конвертації";
            btnBrowseInput.UseVisualStyleBackColor = true;
            btnBrowseInput.Click += btnBrowseInput_Click;
            // 
            // txtInputFile
            // 
            txtInputFile.Location = new Point(12, 50);
            txtInputFile.Name = "txtInputFile";
            txtInputFile.ReadOnly = true;
            txtInputFile.Size = new Size(313, 23);
            txtInputFile.TabIndex = 1;
            // 
            // btnBrowseOutput
            // 
            btnBrowseOutput.Font = new Font("Impact", 14.25F);
            btnBrowseOutput.Location = new Point(12, 91);
            btnBrowseOutput.Name = "btnBrowseOutput";
            btnBrowseOutput.Size = new Size(313, 32);
            btnBrowseOutput.TabIndex = 2;
            btnBrowseOutput.Text = "Вибрати папку для збереження";
            btnBrowseOutput.UseVisualStyleBackColor = true;
            btnBrowseOutput.Click += btnBrowseOutput_Click;
            // 
            // txtOuputFile
            // 
            txtOuputFile.Location = new Point(12, 129);
            txtOuputFile.Name = "txtOuputFile";
            txtOuputFile.ReadOnly = true;
            txtOuputFile.Size = new Size(313, 23);
            txtOuputFile.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14.25F);
            label1.Location = new Point(12, 160);
            label1.Name = "label1";
            label1.Size = new Size(189, 23);
            label1.TabIndex = 4;
            label1.Text = "Виберіть mp3 або wav";
            // 
            // cmbOutputFormat
            // 
            cmbOutputFormat.FormattingEnabled = true;
            cmbOutputFormat.Items.AddRange(new object[] { "mp3", "wav" });
            cmbOutputFormat.Location = new Point(12, 186);
            cmbOutputFormat.Name = "cmbOutputFormat";
            cmbOutputFormat.Size = new Size(313, 23);
            cmbOutputFormat.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F);
            label2.Location = new Point(12, 222);
            label2.Name = "label2";
            label2.Size = new Size(284, 23);
            label2.TabIndex = 6;
            label2.Text = "Напишіть назву файла + формат";
            // 
            // txtOutputFileName
            // 
            txtOutputFileName.Font = new Font("Segoe UI", 12F);
            txtOutputFileName.Location = new Point(12, 248);
            txtOutputFileName.Name = "txtOutputFileName";
            txtOutputFileName.PlaceholderText = "name.mp3 або name.wav";
            txtOutputFileName.Size = new Size(313, 29);
            txtOutputFileName.TabIndex = 7;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Impact", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnConvert.ForeColor = SystemColors.ControlText;
            btnConvert.Location = new Point(12, 294);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(313, 71);
            btnConvert.TabIndex = 8;
            btnConvert.Text = "Конвертувати";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // Convert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 375);
            Controls.Add(btnConvert);
            Controls.Add(txtOutputFileName);
            Controls.Add(label2);
            Controls.Add(cmbOutputFormat);
            Controls.Add(label1);
            Controls.Add(txtOuputFile);
            Controls.Add(btnBrowseOutput);
            Controls.Add(txtInputFile);
            Controls.Add(btnBrowseInput);
            Name = "Convert";
            Text = "Convert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowseInput;
        private TextBox txtInputFile;
        private Button btnBrowseOutput;
        private TextBox txtOuputFile;
        private Label label1;
        private ComboBox cmbOutputFormat;
        private Label label2;
        private TextBox txtOutputFileName;
        private Button btnConvert;
    }
}
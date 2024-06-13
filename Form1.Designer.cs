namespace Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openBtnConvert = new Button();
            openBtnTrim = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // openBtnConvert
            // 
            openBtnConvert.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            openBtnConvert.Location = new Point(12, 12);
            openBtnConvert.Name = "openBtnConvert";
            openBtnConvert.Size = new Size(379, 77);
            openBtnConvert.TabIndex = 0;
            openBtnConvert.Text = "Конвертація mp3/wav";
            openBtnConvert.UseVisualStyleBackColor = true;
            openBtnConvert.Click += openBtnConvert_Click;
            // 
            // openBtnTrim
            // 
            openBtnTrim.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            openBtnTrim.Location = new Point(12, 105);
            openBtnTrim.Name = "openBtnTrim";
            openBtnTrim.Size = new Size(379, 77);
            openBtnTrim.TabIndex = 1;
            openBtnTrim.Text = "Обрізати музику";
            openBtnTrim.UseVisualStyleBackColor = true;
            openBtnTrim.Click += openBtnTrim_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 196);
            label1.Name = "label1";
            label1.Size = new Size(191, 23);
            label1.TabIndex = 2;
            label1.Text = "Підтримати розробку";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 219);
            label2.Name = "label2";
            label2.Size = new Size(216, 23);
            label2.TabIndex = 3;
            label2.Text = "mono: 4441 1144 4535 6932";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 259);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(openBtnTrim);
            Controls.Add(openBtnConvert);
            Name = "Form1";
            Text = "Меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openBtnConvert;
        private Button openBtnTrim;
        private Label label1;
        private Label label2;
    }
}

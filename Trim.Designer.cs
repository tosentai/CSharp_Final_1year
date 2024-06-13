namespace Final
{
    partial class Trim
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
            btnBrowseFileTrim = new Button();
            txtInputFileTrim = new TextBox();
            btnBrowseOutputTrim = new Button();
            txtOutputFileTrim = new TextBox();
            trackBarStart = new TrackBar();
            trackBarEnd = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            btnTrim = new Button();
            startTime = new Label();
            endTime = new Label();
            label3 = new Label();
            label4 = new Label();
            btnPlay = new Button();
            btnStop = new Button();
            lblCurrentTime = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarEnd).BeginInit();
            SuspendLayout();
            // 
            // btnBrowseFileTrim
            // 
            btnBrowseFileTrim.Font = new Font("Impact", 14.25F);
            btnBrowseFileTrim.Location = new Point(12, 12);
            btnBrowseFileTrim.Name = "btnBrowseFileTrim";
            btnBrowseFileTrim.Size = new Size(412, 32);
            btnBrowseFileTrim.TabIndex = 0;
            btnBrowseFileTrim.Text = "Вибрати файл для обрізки";
            btnBrowseFileTrim.UseVisualStyleBackColor = true;
            btnBrowseFileTrim.Click += btnBrowseFileTrim_Click;
            // 
            // txtInputFileTrim
            // 
            txtInputFileTrim.Location = new Point(12, 50);
            txtInputFileTrim.Name = "txtInputFileTrim";
            txtInputFileTrim.ReadOnly = true;
            txtInputFileTrim.Size = new Size(412, 23);
            txtInputFileTrim.TabIndex = 1;
            // 
            // btnBrowseOutputTrim
            // 
            btnBrowseOutputTrim.Font = new Font("Impact", 14.25F);
            btnBrowseOutputTrim.Location = new Point(12, 90);
            btnBrowseOutputTrim.Name = "btnBrowseOutputTrim";
            btnBrowseOutputTrim.Size = new Size(412, 32);
            btnBrowseOutputTrim.TabIndex = 2;
            btnBrowseOutputTrim.Text = "Вибрати папку для збереження";
            btnBrowseOutputTrim.UseVisualStyleBackColor = true;
            btnBrowseOutputTrim.Click += btnBrowseOutputTrim_Click;
            // 
            // txtOutputFileTrim
            // 
            txtOutputFileTrim.Location = new Point(12, 128);
            txtOutputFileTrim.Name = "txtOutputFileTrim";
            txtOutputFileTrim.ReadOnly = true;
            txtOutputFileTrim.Size = new Size(412, 23);
            txtOutputFileTrim.TabIndex = 3;
            // 
            // trackBarStart
            // 
            trackBarStart.Location = new Point(12, 191);
            trackBarStart.Name = "trackBarStart";
            trackBarStart.Size = new Size(247, 45);
            trackBarStart.TabIndex = 4;
            trackBarStart.Scroll += trackBarStart_Scroll;
            // 
            // trackBarEnd
            // 
            trackBarEnd.Location = new Point(12, 255);
            trackBarEnd.Name = "trackBarEnd";
            trackBarEnd.Size = new Size(247, 45);
            trackBarEnd.TabIndex = 5;
            trackBarEnd.Scroll += trackBarEnd_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14.25F);
            label1.Location = new Point(12, 165);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 6;
            label1.Text = "Початок";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F);
            label2.Location = new Point(12, 229);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 7;
            label2.Text = "Кінець";
            // 
            // btnTrim
            // 
            btnTrim.Font = new Font("Impact", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnTrim.Location = new Point(12, 306);
            btnTrim.Name = "btnTrim";
            btnTrim.Size = new Size(273, 71);
            btnTrim.TabIndex = 8;
            btnTrim.Text = "Обрізати";
            btnTrim.UseVisualStyleBackColor = true;
            btnTrim.Click += btnTrim_Click;
            // 
            // startTime
            // 
            startTime.AutoSize = true;
            startTime.Font = new Font("Impact", 14.25F);
            startTime.Location = new Point(265, 191);
            startTime.Name = "startTime";
            startTime.Size = new Size(0, 23);
            startTime.TabIndex = 9;
            // 
            // endTime
            // 
            endTime.AutoSize = true;
            endTime.Font = new Font("Impact", 14.25F);
            endTime.Location = new Point(265, 255);
            endTime.Name = "endTime";
            endTime.Size = new Size(0, 23);
            endTime.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 14.25F);
            label3.Location = new Point(265, 191);
            label3.Name = "label3";
            label3.Size = new Size(20, 23);
            label3.TabIndex = 11;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 14.25F);
            label4.Location = new Point(265, 255);
            label4.Name = "label4";
            label4.Size = new Size(20, 23);
            label4.TabIndex = 12;
            label4.Text = "0";
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Impact", 14.25F);
            btnPlay.Location = new Point(305, 184);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(119, 42);
            btnPlay.TabIndex = 13;
            btnPlay.Text = "Прослухати";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Impact", 14.25F);
            btnStop.Location = new Point(305, 248);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(119, 42);
            btnStop.TabIndex = 14;
            btnStop.Text = "Зупинити";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.Font = new Font("Impact", 14.25F);
            lblCurrentTime.Location = new Point(330, 337);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(100, 23);
            lblCurrentTime.TabIndex = 2;
            lblCurrentTime.Text = "00:00:00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(297, 306);
            label5.Name = "label5";
            label5.Size = new Size(140, 21);
            label5.TabIndex = 15;
            label5.Text = "Поточна секунда:";
            label5.UseWaitCursor = true;
            // 
            // Trim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 393);
            Controls.Add(label5);
            Controls.Add(lblCurrentTime);
            Controls.Add(btnStop);
            Controls.Add(btnPlay);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(endTime);
            Controls.Add(startTime);
            Controls.Add(btnTrim);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBarEnd);
            Controls.Add(trackBarStart);
            Controls.Add(txtOutputFileTrim);
            Controls.Add(btnBrowseOutputTrim);
            Controls.Add(txtInputFileTrim);
            Controls.Add(btnBrowseFileTrim);
            Name = "Trim";
            Text = "Trim";
            ((System.ComponentModel.ISupportInitialize)trackBarStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarEnd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowseFileTrim;
        private TextBox txtInputFileTrim;
        private Button btnBrowseOutputTrim;
        private TextBox txtOutputFileTrim;
        private TrackBar trackBarStart;
        private TrackBar trackBarEnd;
        private Label label1;
        private Label label2;
        private Button btnTrim;
        private Label startTime;
        private Label endTime;
        private Label label3;
        private Label label4;
        private Button btnPlay;
        private Button btnStop;
        private Label lblCurrentTime;
        private Label label5;
    }
}
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Timers;

namespace Final
{
    public partial class Trim : Form
    {
        private WaveOutEvent waveOut;
        private AudioFileReader audioFileReader;
        private System.Windows.Forms.Timer stopTimer;
        private System.Windows.Forms.Timer updateTimer;

        public Trim()
        {
            InitializeComponent();
        }

        private void btnBrowseFileTrim_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Audio Files|*.wav;*.mp3";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtInputFileTrim.Text = openFileDialog.FileName;
                    string filePath = openFileDialog.FileName;
                    SetTrackBarMaximum(filePath);
                }
            }
        }

        private void SetTrackBarMaximum(string filePath)
        {
            using (var audioFile = new AudioFileReader(filePath))
            {
                double trackLength = audioFile.TotalTime.TotalSeconds;
                trackBarStart.Maximum = (int)trackLength;
                trackBarEnd.Maximum = (int)trackLength;
            }
        }

        private void btnBrowseOutputTrim_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtOutputFileTrim.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void TrimAudio(string inputFilePath, string outputFilePath, TimeSpan startTime, TimeSpan endTime)
        {
            using (var reader = new AudioFileReader(inputFilePath))
            {
                var trimFrom = startTime;
                var trimTo = endTime;

                if (trimFrom < TimeSpan.Zero)
                    trimFrom = TimeSpan.Zero;

                if (trimTo > reader.TotalTime)
                    trimTo = reader.TotalTime;

                var outputFormat = new WaveFormat(reader.WaveFormat.SampleRate, reader.WaveFormat.BitsPerSample, reader.WaveFormat.Channels);

                using (var writer = new WaveFileWriter(outputFilePath, outputFormat))
                {
                    reader.CurrentTime = trimFrom;

                    while (reader.CurrentTime <= trimTo)
                    {
                        var bytesRequired = (int)((trimTo - reader.CurrentTime).TotalSeconds * reader.WaveFormat.AverageBytesPerSecond);
                        var bytes = new byte[bytesRequired];
                        var bytesRead = reader.Read(bytes, 0, bytesRequired);

                        if (bytesRead > 0)
                            writer.Write(bytes, 0, bytesRead);
                        else
                            break;
                    }
                }
            }
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            string inputFilePath = txtInputFileTrim.Text;
            string outputDirectory = txtOutputFileTrim.Text;
            int totalSecondsStart = trackBarStart.Value;
            int totalSecondsEnd = trackBarEnd.Value;
            TimeSpan timeSpanStart = TimeSpan.FromSeconds(totalSecondsStart);
            TimeSpan timeSpanEnd = TimeSpan.FromSeconds(totalSecondsEnd);
            string formattedTimeStart = timeSpanStart.ToString(@"hh\:mm\:ss");
            string formattedTimeEnd = timeSpanEnd.ToString(@"hh\:mm\:ss");
            TimeSpan startTime = TimeSpan.Parse(formattedTimeStart);
            TimeSpan endTime = TimeSpan.Parse(formattedTimeEnd);

            if (string.IsNullOrEmpty(inputFilePath) || string.IsNullOrEmpty(outputDirectory))
            {
                MessageBox.Show("Виберіть файл, і куди зберігати", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (endTime <= startTime)
            {
                MessageBox.Show("Стартова позиція обрізки не може бути більшим за кінцеву позицію", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string outputFilePath = System.IO.Path.Combine(outputDirectory, "trimmed_audio.wav");

            try
            {
                TrimAudio(inputFilePath, outputFilePath, startTime, endTime);
                MessageBox.Show("Пісня успішно обрізана", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackBarStart_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBarStart.Value.ToString();
        }

        private void trackBarEnd_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBarEnd.Value.ToString();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string filePath = txtInputFileTrim.Text;
            double startTime = trackBarStart.Value;
            double endTime = trackBarEnd.Value;

            try
            {
                if (waveOut != null)
                {
                    waveOut.Dispose();
                }

                if (audioFileReader != null)
                {
                    audioFileReader.Dispose();
                }

                audioFileReader = new AudioFileReader(filePath);
                waveOut = new WaveOutEvent();
                waveOut.Init(audioFileReader);


                audioFileReader.CurrentTime = TimeSpan.FromSeconds(startTime);

                waveOut.Play();

                stopTimer = new System.Windows.Forms.Timer();
                stopTimer.Interval = (int)((endTime - startTime) * 1000);
                stopTimer.Tick += StopTimer_Tick;
                stopTimer.Start();

                updateTimer = new System.Windows.Forms.Timer();
                updateTimer.Interval = 1000;
                updateTimer.Tick += UpdateTimer_Tick;
                updateTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при програванні: " + ex.Message);
            }
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                lblCurrentTime.Text = audioFileReader.CurrentTime.ToString(@"hh\:mm\:ss");
            }
        }

        private void StopTimer_Tick(object sender, EventArgs e)
        {
            waveOut.Stop();
            stopTimer.Stop();
            updateTimer.Stop();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                waveOut.Stop();
            }
            if (stopTimer != null)
            {
                stopTimer.Stop();
            }
            if (updateTimer != null)
            {
                updateTimer.Stop();
            }
        }
    }
}

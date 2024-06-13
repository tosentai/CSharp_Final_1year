using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Lame;

namespace Final
{
    public partial class Convert : Form
    {
        public Convert()
        {
            InitializeComponent();
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Audio Files|*.mp3;*.wav";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtInputFile.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtOuputFile.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        static void ConvertMp3ToWav(string mp3File, string wavFile)
        {
            using (var reader = new Mp3FileReader(mp3File))
            using (var writer = new WaveFileWriter(wavFile, reader.WaveFormat))
            {
                reader.CopyTo(writer);
            }
        }

        static void ConvertWavToMp3(string wavFile, string mp3File)
        {
            using (var reader = new WaveFileReader(wavFile))
            using (var writer = new LameMP3FileWriter(mp3File, reader.WaveFormat, LAMEPreset.STANDARD))
            {
                reader.CopyTo(writer);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string inputFilePath = txtInputFile.Text;
            string outputDirectory = txtOuputFile.Text;
            string outputFileName = txtOutputFileName.Text;
            string outputFormat = cmbOutputFormat.SelectedItem?.ToString().ToLower();

            if (string.IsNullOrEmpty(inputFilePath) || string.IsNullOrEmpty(outputDirectory) || string.IsNullOrEmpty(outputFileName) || string.IsNullOrEmpty(outputFormat))
            {
                MessageBox.Show("Áóäü-ëàñêà âêàæ³òü âõ³äíèé ôàéë, âèõ³äíèé êàòàëîã, íàçâó âèõ³äíîãî ôàéëó òà âèõ³äíèé ôîðìàò", "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string outputFilePath = System.IO.Path.Combine(outputDirectory, outputFileName);

            try
            {
                if (outputFormat == "mp3")
                {
                    ConvertWavToMp3(inputFilePath, outputFilePath);
                    MessageBox.Show("Àóä³îôàéë óñï³øíî êîíâåðòîâàíî", "Óñï³øíî", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (outputFormat == "wav")
                {
                    ConvertMp3ToWav(inputFilePath, outputFilePath);
                    MessageBox.Show("Àóä³îôàéë óñï³øíî êîíâåðòîâàíî", "Óñï³øíî", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Íåï³äòðèìóâàíèé ôîðìàò. Ï³äòðèìóâàí³ ôîðìàòè: mp3, wav", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ï³ä ÷àñ êîíâåðòàö³¿ ñòàëàñÿ ïîìèëêà: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

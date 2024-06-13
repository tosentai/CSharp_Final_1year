using System.Diagnostics;

namespace Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openBtnConvert_Click(object sender, EventArgs e)
        {
            Convert convertForm = new Convert();
            convertForm.ShowDialog();
        }

        private void openBtnTrim_Click(object sender, EventArgs e)
        {
            Trim trimForm = new Trim();
            trimForm.ShowDialog();
        }
    }
}

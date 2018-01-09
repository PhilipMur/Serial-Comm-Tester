using System;
using System.IO;
using System.Windows.Forms;

namespace Serial_Comm_Tester
{
    public partial class HexChart : Form
    {
        public static string StartupPath { get; }
        public HexChart()
        {
            InitializeComponent();
        }

        private async void btnHexChart_Click(object sender, EventArgs e)
        {
              richTextBox1.Text = "";
            // const string app =  Application.StartupPath();

            //  using (StreamReader sr = new StreamReader(Application.StartupPath + "\\" + "HEX_to_ASCII.txt"))

            try
            {
                using (StreamReader sr = new StreamReader("HEX_to_ASCII.txt"))
                {
                    richTextBox1.Text = await sr.ReadToEndAsync();
                }
            }
            catch 
            {

                MessageBox.Show( "File missing or wrong directory" , "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

          

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnUnicodeChart_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            // const string app =  Application.StartupPath();

            //  using (StreamReader sr = new StreamReader(Application.StartupPath + "\\" + "Unicode_characters.txt"))

            try
            {
                using (StreamReader sr = new StreamReader("Unicode_characters.txt"))
                {
                    richTextBox1.Text = await sr.ReadToEndAsync();
                }
            }
            catch 
            {
                MessageBox.Show("File missing or wrong directory", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
          
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
          
           
        }

        private void copySelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == "" && richTextBox1.Text != "")
            {
                Clipboard.SetText(richTextBox1.Text);
            }
           
            if (richTextBox1.SelectedText != "")
            {
                Clipboard.SetText(richTextBox1.SelectedText);
            }

        }

        private void checkBoxBringToFront_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxBringToFront.Checked == true)
            {
                TopMost = true;
            }
            if (checkBoxBringToFront.Checked == false)
            {
                TopMost = false;
            }
        }
    }
}

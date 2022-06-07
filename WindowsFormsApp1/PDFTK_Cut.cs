using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class PDFTK_CUT : Form
    {
        private bool pagesREGEXValid = true;

        public PDFTK_CUT()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void OpenPDFFile_Click(object sender, EventArgs e)
        {
            openPDFDialog.ShowDialog();
        }

        private void openPDFDialog_FileOk(object sender, CancelEventArgs e)
        {
            fileLocation.Text = openPDFDialog.FileName;
        }

        private void SavePDFFile_Click(object sender, EventArgs e)
        {
            savePDFDialog.ShowDialog();
        }

        private void savePDFDialog_FileOk(object sender, CancelEventArgs e)
        {
            outFileLocation.Text = savePDFDialog.FileName;
        }

        private void pageTXTBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(pageTXTBox.Text, "^[1-9]+-[1-9]+$|^[1-9]+-end$").Success)
            {
                pagesREGEXValid = true;
                pagesValid.Image = System.Drawing.Image.FromFile(".\\res\\checkmark.png");
            }
            else
            {
                pagesREGEXValid = false;
                pagesValid.Image = System.Drawing.Image.FromFile(".\\res\\x.png");
            }
        }

        private void RunSave_Click(object sender, EventArgs e)
        {
            if (pagesREGEXValid)
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = $"/C pdftk \"{fileLocation.Text}\" cat {pageTXTBox.Text} output \"{outFileLocation.Text}\"";
                process.StartInfo = startInfo;
                process.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Page Selection Is INVALID", "Page Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

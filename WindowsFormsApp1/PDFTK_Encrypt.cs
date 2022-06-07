using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PDFTK_Encrypt : Form
    {
        private string allowPrinting = "";

        public PDFTK_Encrypt()
        {
            InitializeComponent();
        }

        private void OpenPDFFile_Click(object sender, EventArgs e)
        {
            openPDFDialog.ShowDialog();
        }

        private void SavePDFFile_Click(object sender, EventArgs e)
        {
            savePDFDialog.ShowDialog();
        }

        private void openPDFDialog_FileOk(object sender, CancelEventArgs e)
        {
            fileLocation.Text = openPDFDialog.FileName;
        }

        private void savePDFDialog_FileOk(object sender, CancelEventArgs e)
        {
            outFileLocation.Text = savePDFDialog.FileName;
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                passwordInput.PasswordChar = '\0';
            }
            else
            {
                passwordInput.PasswordChar = '*';
            }
        }

        private void RunSave_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/C pdftk \"{fileLocation.Text}\" output \"{outFileLocation.Text}\" owner_pw {passwordInput.Text} {allowPrinting}";
            process.StartInfo = startInfo;
            process.Start();
            this.Close();
        }

        private void printPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (printPassword.Checked)
            {
                allowPrinting = "allow printing";
            }
            else
            {
                allowPrinting = "";
            }
        }
    }
}

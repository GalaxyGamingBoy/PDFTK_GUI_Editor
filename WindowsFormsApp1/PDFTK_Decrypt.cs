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
    public partial class PDFTK_Decrypt : Form
    {
        public PDFTK_Decrypt()
        {
            InitializeComponent();
        }

        private void OpenPDFFile_Click(object sender, EventArgs e)
        {
            openPDFDialog.ShowDialog();
        }

        private void openPDFDialog_FileOk(object sender, CancelEventArgs e)
        {
            inFileLocation.Text = openPDFDialog.FileName;
        }

        private void SavePDFFile_Click(object sender, EventArgs e)
        {
            savePDFDialog.ShowDialog();
        }

        private void savePDFDialog_FileOk(object sender, CancelEventArgs e)
        {
            outFileLocation.Text = savePDFDialog.FileName;
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/C pdftk \"{inFileLocation.Text}\" input_pw {password.Text} output \"{outFileLocation.Text}\"";
            process.StartInfo = startInfo;
            process.Start();
            this.Close();
        }
    }
}

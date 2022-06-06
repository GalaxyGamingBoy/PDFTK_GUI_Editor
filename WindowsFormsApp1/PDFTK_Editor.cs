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
    public partial class PDFTK_Editor : Form
    {
        public PDFTK_Editor()
        {
            InitializeComponent();
        }

        private void cut_Click(object sender, EventArgs e)
        {
            PDFTK_CUT cutForm = new PDFTK_CUT();
            cutForm.Show();
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            PDFTK_Encrypt encryptForm = new PDFTK_Encrypt();
            encryptForm.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

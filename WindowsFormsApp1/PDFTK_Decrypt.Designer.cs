namespace WindowsFormsApp1
{
    partial class PDFTK_Decrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFTK_Decrypt));
            this.inputPDF = new System.Windows.Forms.Label();
            this.inFileLocation = new System.Windows.Forms.Label();
            this.OpenPDFFile = new System.Windows.Forms.Button();
            this.outputPDF = new System.Windows.Forms.Label();
            this.outFileLocation = new System.Windows.Forms.Label();
            this.SavePDFFile = new System.Windows.Forms.Button();
            this.openPDFDialog = new System.Windows.Forms.OpenFileDialog();
            this.savePDFDialog = new System.Windows.Forms.SaveFileDialog();
            this.examplePassword = new System.Windows.Forms.Label();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.Run = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputPDF
            // 
            this.inputPDF.AutoSize = true;
            this.inputPDF.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.inputPDF.Location = new System.Drawing.Point(12, 9);
            this.inputPDF.Name = "inputPDF";
            this.inputPDF.Size = new System.Drawing.Size(132, 22);
            this.inputPDF.TabIndex = 2;
            this.inputPDF.Text = "Input PDF File: ";
            // 
            // inFileLocation
            // 
            this.inFileLocation.AutoSize = true;
            this.inFileLocation.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Italic);
            this.inFileLocation.Location = new System.Drawing.Point(244, 9);
            this.inFileLocation.Name = "inFileLocation";
            this.inFileLocation.Size = new System.Drawing.Size(120, 22);
            this.inFileLocation.TabIndex = 4;
            this.inFileLocation.Text = ".\\inputFile.pdf";
            // 
            // OpenPDFFile
            // 
            this.OpenPDFFile.Font = new System.Drawing.Font("Roboto", 8F);
            this.OpenPDFFile.Location = new System.Drawing.Point(163, 8);
            this.OpenPDFFile.Name = "OpenPDFFile";
            this.OpenPDFFile.Size = new System.Drawing.Size(75, 23);
            this.OpenPDFFile.TabIndex = 5;
            this.OpenPDFFile.Text = "Open";
            this.OpenPDFFile.UseVisualStyleBackColor = true;
            this.OpenPDFFile.Click += new System.EventHandler(this.OpenPDFFile_Click);
            // 
            // outputPDF
            // 
            this.outputPDF.AutoSize = true;
            this.outputPDF.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.outputPDF.Location = new System.Drawing.Point(12, 45);
            this.outputPDF.Name = "outputPDF";
            this.outputPDF.Size = new System.Drawing.Size(145, 22);
            this.outputPDF.TabIndex = 6;
            this.outputPDF.Text = "Output PDF File: ";
            // 
            // outFileLocation
            // 
            this.outFileLocation.AutoSize = true;
            this.outFileLocation.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Italic);
            this.outFileLocation.Location = new System.Drawing.Point(244, 45);
            this.outFileLocation.Name = "outFileLocation";
            this.outFileLocation.Size = new System.Drawing.Size(132, 22);
            this.outFileLocation.TabIndex = 7;
            this.outFileLocation.Text = ".\\outputFile.pdf";
            // 
            // SavePDFFile
            // 
            this.SavePDFFile.Font = new System.Drawing.Font("Roboto", 8F);
            this.SavePDFFile.Location = new System.Drawing.Point(163, 44);
            this.SavePDFFile.Name = "SavePDFFile";
            this.SavePDFFile.Size = new System.Drawing.Size(75, 23);
            this.SavePDFFile.TabIndex = 8;
            this.SavePDFFile.Text = "Open";
            this.SavePDFFile.UseVisualStyleBackColor = true;
            this.SavePDFFile.Click += new System.EventHandler(this.SavePDFFile_Click);
            // 
            // openPDFDialog
            // 
            this.openPDFDialog.FileName = "inputFile";
            this.openPDFDialog.Filter = "PDF File|*.pdf";
            this.openPDFDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openPDFDialog_FileOk);
            // 
            // savePDFDialog
            // 
            this.savePDFDialog.FileName = "outputFile.pdf";
            this.savePDFDialog.Filter = "PDF File|*.pdf";
            this.savePDFDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.savePDFDialog_FileOk);
            // 
            // examplePassword
            // 
            this.examplePassword.AutoSize = true;
            this.examplePassword.Font = new System.Drawing.Font("Roboto", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.examplePassword.Location = new System.Drawing.Point(244, 105);
            this.examplePassword.Name = "examplePassword";
            this.examplePassword.Size = new System.Drawing.Size(128, 18);
            this.examplePassword.TabIndex = 18;
            this.examplePassword.Text = "Default: password";
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Font = new System.Drawing.Font("Roboto", 8F);
            this.showPassword.Location = new System.Drawing.Point(122, 129);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(105, 17);
            this.showPassword.TabIndex = 17;
            this.showPassword.Text = "Show Password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Roboto", 12F);
            this.password.Location = new System.Drawing.Point(122, 96);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(116, 27);
            this.password.TabIndex = 16;
            this.password.Text = "password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.Location = new System.Drawing.Point(9, 98);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(99, 22);
            this.passwordLabel.TabIndex = 15;
            this.passwordLabel.Text = "Password: ";
            // 
            // Run
            // 
            this.Run.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.Run.Location = new System.Drawing.Point(542, 178);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(150, 35);
            this.Run.TabIndex = 19;
            this.Run.Text = "Run, Save, Exit";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.titleLabel.Location = new System.Drawing.Point(559, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(133, 22);
            this.titleLabel.TabIndex = 20;
            this.titleLabel.Text = "PDFTK Decrypt";
            // 
            // PDFTK_Decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 225);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.examplePassword);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.SavePDFFile);
            this.Controls.Add(this.outFileLocation);
            this.Controls.Add(this.outputPDF);
            this.Controls.Add(this.OpenPDFFile);
            this.Controls.Add(this.inFileLocation);
            this.Controls.Add(this.inputPDF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PDFTK_Decrypt";
            this.Text = "DPFTK_Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputPDF;
        private System.Windows.Forms.Label inFileLocation;
        private System.Windows.Forms.Button OpenPDFFile;
        private System.Windows.Forms.Label outputPDF;
        private System.Windows.Forms.Label outFileLocation;
        private System.Windows.Forms.Button SavePDFFile;
        private System.Windows.Forms.OpenFileDialog openPDFDialog;
        private System.Windows.Forms.SaveFileDialog savePDFDialog;
        private System.Windows.Forms.Label examplePassword;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label titleLabel;
    }
}
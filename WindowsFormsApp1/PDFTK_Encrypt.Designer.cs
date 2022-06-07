namespace WindowsFormsApp1
{
    partial class PDFTK_Encrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFTK_Encrypt));
            this.inputPDF = new System.Windows.Forms.Label();
            this.fileLocation = new System.Windows.Forms.Label();
            this.OpenPDFFile = new System.Windows.Forms.Button();
            this.outputPDF = new System.Windows.Forms.Label();
            this.outFileLocation = new System.Windows.Forms.Label();
            this.SavePDFFile = new System.Windows.Forms.Button();
            this.RunSave = new System.Windows.Forms.Button();
            this.openPDFDialog = new System.Windows.Forms.OpenFileDialog();
            this.savePDFDialog = new System.Windows.Forms.SaveFileDialog();
            this.password = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.example = new System.Windows.Forms.Label();
            this.printPassword = new System.Windows.Forms.CheckBox();
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
            this.inputPDF.TabIndex = 1;
            this.inputPDF.Text = "Input PDF File: ";
            // 
            // fileLocation
            // 
            this.fileLocation.AutoSize = true;
            this.fileLocation.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Italic);
            this.fileLocation.Location = new System.Drawing.Point(244, 9);
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(120, 22);
            this.fileLocation.TabIndex = 3;
            this.fileLocation.Text = ".\\inputFile.pdf";
            // 
            // OpenPDFFile
            // 
            this.OpenPDFFile.Font = new System.Drawing.Font("Roboto", 8F);
            this.OpenPDFFile.Location = new System.Drawing.Point(163, 8);
            this.OpenPDFFile.Name = "OpenPDFFile";
            this.OpenPDFFile.Size = new System.Drawing.Size(75, 23);
            this.OpenPDFFile.TabIndex = 4;
            this.OpenPDFFile.Text = "Open";
            this.OpenPDFFile.UseVisualStyleBackColor = true;
            this.OpenPDFFile.Click += new System.EventHandler(this.OpenPDFFile_Click);
            // 
            // outputPDF
            // 
            this.outputPDF.AutoSize = true;
            this.outputPDF.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.outputPDF.Location = new System.Drawing.Point(12, 50);
            this.outputPDF.Name = "outputPDF";
            this.outputPDF.Size = new System.Drawing.Size(145, 22);
            this.outputPDF.TabIndex = 5;
            this.outputPDF.Text = "Output PDF File: ";
            // 
            // outFileLocation
            // 
            this.outFileLocation.AutoSize = true;
            this.outFileLocation.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Italic);
            this.outFileLocation.Location = new System.Drawing.Point(244, 48);
            this.outFileLocation.Name = "outFileLocation";
            this.outFileLocation.Size = new System.Drawing.Size(132, 22);
            this.outFileLocation.TabIndex = 6;
            this.outFileLocation.Text = ".\\outputFile.pdf";
            // 
            // SavePDFFile
            // 
            this.SavePDFFile.Font = new System.Drawing.Font("Roboto", 8F);
            this.SavePDFFile.Location = new System.Drawing.Point(163, 49);
            this.SavePDFFile.Name = "SavePDFFile";
            this.SavePDFFile.Size = new System.Drawing.Size(75, 23);
            this.SavePDFFile.TabIndex = 7;
            this.SavePDFFile.Text = "Open";
            this.SavePDFFile.UseVisualStyleBackColor = true;
            this.SavePDFFile.Click += new System.EventHandler(this.SavePDFFile_Click);
            // 
            // RunSave
            // 
            this.RunSave.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.RunSave.Location = new System.Drawing.Point(542, 178);
            this.RunSave.Name = "RunSave";
            this.RunSave.Size = new System.Drawing.Size(150, 35);
            this.RunSave.TabIndex = 10;
            this.RunSave.Text = "Run, Save, Exit";
            this.RunSave.UseVisualStyleBackColor = true;
            this.RunSave.Click += new System.EventHandler(this.RunSave_Click);
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
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.password.Location = new System.Drawing.Point(12, 109);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(99, 22);
            this.password.TabIndex = 11;
            this.password.Text = "Password: ";
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Roboto", 12F);
            this.passwordInput.Location = new System.Drawing.Point(117, 107);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(116, 27);
            this.passwordInput.TabIndex = 12;
            this.passwordInput.Text = "password";
            this.passwordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Font = new System.Drawing.Font("Roboto", 8F);
            this.showPassword.Location = new System.Drawing.Point(117, 140);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(105, 17);
            this.showPassword.TabIndex = 13;
            this.showPassword.Text = "Show Password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // example
            // 
            this.example.AutoSize = true;
            this.example.Font = new System.Drawing.Font("Roboto", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.example.Location = new System.Drawing.Point(239, 116);
            this.example.Name = "example";
            this.example.Size = new System.Drawing.Size(128, 18);
            this.example.TabIndex = 14;
            this.example.Text = "Default: password";
            // 
            // printPassword
            // 
            this.printPassword.AutoSize = true;
            this.printPassword.Font = new System.Drawing.Font("Roboto", 10F);
            this.printPassword.Location = new System.Drawing.Point(12, 187);
            this.printPassword.Name = "printPassword";
            this.printPassword.Size = new System.Drawing.Size(239, 21);
            this.printPassword.TabIndex = 16;
            this.printPassword.Text = "Allow Printning Without Password";
            this.printPassword.UseVisualStyleBackColor = true;
            this.printPassword.CheckedChanged += new System.EventHandler(this.printPassword_CheckedChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.titleLabel.Location = new System.Drawing.Point(561, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(131, 22);
            this.titleLabel.TabIndex = 21;
            this.titleLabel.Text = "PDFTK Encrypt";
            // 
            // PDFTK_Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 225);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.printPassword);
            this.Controls.Add(this.example);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.password);
            this.Controls.Add(this.RunSave);
            this.Controls.Add(this.SavePDFFile);
            this.Controls.Add(this.outFileLocation);
            this.Controls.Add(this.outputPDF);
            this.Controls.Add(this.OpenPDFFile);
            this.Controls.Add(this.fileLocation);
            this.Controls.Add(this.inputPDF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PDFTK_Encrypt";
            this.Text = "PDFTK_Encrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputPDF;
        private System.Windows.Forms.Label fileLocation;
        private System.Windows.Forms.Button OpenPDFFile;
        private System.Windows.Forms.Label outputPDF;
        private System.Windows.Forms.Label outFileLocation;
        private System.Windows.Forms.Button SavePDFFile;
        private System.Windows.Forms.Button RunSave;
        private System.Windows.Forms.OpenFileDialog openPDFDialog;
        private System.Windows.Forms.SaveFileDialog savePDFDialog;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Label example;
        private System.Windows.Forms.CheckBox printPassword;
        private System.Windows.Forms.Label titleLabel;
    }
}
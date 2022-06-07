namespace WindowsFormsApp1
{
    partial class PDFTK_CUT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFTK_CUT));
            this.inputPDF = new System.Windows.Forms.Label();
            this.OpenPDFFile = new System.Windows.Forms.Button();
            this.openPDFDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileLocation = new System.Windows.Forms.Label();
            this.savePDFDialog = new System.Windows.Forms.SaveFileDialog();
            this.outputPDF = new System.Windows.Forms.Label();
            this.outFileLocation = new System.Windows.Forms.Label();
            this.SavePDFFile = new System.Windows.Forms.Button();
            this.pageSelector = new System.Windows.Forms.Label();
            this.pageTXTBox = new System.Windows.Forms.TextBox();
            this.pagesValid = new System.Windows.Forms.PictureBox();
            this.RunSave = new System.Windows.Forms.Button();
            this.example = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pagesValid)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPDF
            // 
            this.inputPDF.AutoSize = true;
            this.inputPDF.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.inputPDF.Location = new System.Drawing.Point(13, 13);
            this.inputPDF.Name = "inputPDF";
            this.inputPDF.Size = new System.Drawing.Size(132, 22);
            this.inputPDF.TabIndex = 0;
            this.inputPDF.Text = "Input PDF File: ";
            // 
            // OpenPDFFile
            // 
            this.OpenPDFFile.Font = new System.Drawing.Font("Roboto", 8F);
            this.OpenPDFFile.Location = new System.Drawing.Point(163, 13);
            this.OpenPDFFile.Name = "OpenPDFFile";
            this.OpenPDFFile.Size = new System.Drawing.Size(75, 23);
            this.OpenPDFFile.TabIndex = 1;
            this.OpenPDFFile.Text = "Open";
            this.OpenPDFFile.UseVisualStyleBackColor = true;
            this.OpenPDFFile.Click += new System.EventHandler(this.OpenPDFFile_Click);
            // 
            // openPDFDialog
            // 
            this.openPDFDialog.FileName = "inputFile";
            this.openPDFDialog.Filter = "PDF File|*.pdf";
            this.openPDFDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openPDFDialog_FileOk);
            // 
            // fileLocation
            // 
            this.fileLocation.AutoSize = true;
            this.fileLocation.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Italic);
            this.fileLocation.Location = new System.Drawing.Point(244, 14);
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(120, 22);
            this.fileLocation.TabIndex = 2;
            this.fileLocation.Text = ".\\inputFile.pdf";
            // 
            // savePDFDialog
            // 
            this.savePDFDialog.FileName = "outputFile.pdf";
            this.savePDFDialog.Filter = "PDF File|*.pdf";
            this.savePDFDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.savePDFDialog_FileOk);
            // 
            // outputPDF
            // 
            this.outputPDF.AutoSize = true;
            this.outputPDF.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.outputPDF.Location = new System.Drawing.Point(12, 53);
            this.outputPDF.Name = "outputPDF";
            this.outputPDF.Size = new System.Drawing.Size(145, 22);
            this.outputPDF.TabIndex = 3;
            this.outputPDF.Text = "Output PDF File: ";
            // 
            // outFileLocation
            // 
            this.outFileLocation.AutoSize = true;
            this.outFileLocation.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Italic);
            this.outFileLocation.Location = new System.Drawing.Point(244, 51);
            this.outFileLocation.Name = "outFileLocation";
            this.outFileLocation.Size = new System.Drawing.Size(132, 22);
            this.outFileLocation.TabIndex = 4;
            this.outFileLocation.Text = ".\\outputFile.pdf";
            // 
            // SavePDFFile
            // 
            this.SavePDFFile.Font = new System.Drawing.Font("Roboto", 8F);
            this.SavePDFFile.Location = new System.Drawing.Point(163, 52);
            this.SavePDFFile.Name = "SavePDFFile";
            this.SavePDFFile.Size = new System.Drawing.Size(75, 23);
            this.SavePDFFile.TabIndex = 5;
            this.SavePDFFile.Text = "Open";
            this.SavePDFFile.UseVisualStyleBackColor = true;
            this.SavePDFFile.Click += new System.EventHandler(this.SavePDFFile_Click);
            // 
            // pageSelector
            // 
            this.pageSelector.AutoSize = true;
            this.pageSelector.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.pageSelector.Location = new System.Drawing.Point(13, 144);
            this.pageSelector.Name = "pageSelector";
            this.pageSelector.Size = new System.Drawing.Size(125, 22);
            this.pageSelector.TabIndex = 6;
            this.pageSelector.Text = "Select Pages: ";
            // 
            // pageTXTBox
            // 
            this.pageTXTBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.pageTXTBox.Location = new System.Drawing.Point(144, 142);
            this.pageTXTBox.Name = "pageTXTBox";
            this.pageTXTBox.Size = new System.Drawing.Size(116, 27);
            this.pageTXTBox.TabIndex = 7;
            this.pageTXTBox.Text = "1-1";
            this.pageTXTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pageTXTBox.TextChanged += new System.EventHandler(this.pageTXTBox_TextChanged);
            // 
            // pagesValid
            // 
            this.pagesValid.Image = ((System.Drawing.Image)(resources.GetObject("pagesValid.Image")));
            this.pagesValid.Location = new System.Drawing.Point(266, 137);
            this.pagesValid.Name = "pagesValid";
            this.pagesValid.Size = new System.Drawing.Size(36, 36);
            this.pagesValid.TabIndex = 8;
            this.pagesValid.TabStop = false;
            // 
            // RunSave
            // 
            this.RunSave.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.RunSave.Location = new System.Drawing.Point(542, 178);
            this.RunSave.Name = "RunSave";
            this.RunSave.Size = new System.Drawing.Size(150, 35);
            this.RunSave.TabIndex = 9;
            this.RunSave.Text = "Run, Save, Exit";
            this.RunSave.UseVisualStyleBackColor = true;
            this.RunSave.Click += new System.EventHandler(this.RunSave_Click);
            // 
            // example
            // 
            this.example.AutoSize = true;
            this.example.Font = new System.Drawing.Font("Roboto", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.example.Location = new System.Drawing.Point(34, 172);
            this.example.Name = "example";
            this.example.Size = new System.Drawing.Size(155, 18);
            this.example.TabIndex = 10;
            this.example.Text = "Example: 1-5 OR 1-end";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.titleLabel.Location = new System.Drawing.Point(594, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(98, 22);
            this.titleLabel.TabIndex = 21;
            this.titleLabel.Text = "PDFTK Cut";
            // 
            // PDFTK_CUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 225);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.example);
            this.Controls.Add(this.RunSave);
            this.Controls.Add(this.pagesValid);
            this.Controls.Add(this.pageTXTBox);
            this.Controls.Add(this.pageSelector);
            this.Controls.Add(this.SavePDFFile);
            this.Controls.Add(this.outFileLocation);
            this.Controls.Add(this.outputPDF);
            this.Controls.Add(this.fileLocation);
            this.Controls.Add(this.OpenPDFFile);
            this.Controls.Add(this.inputPDF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PDFTK_CUT";
            this.Text = "PDFTK Cut";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pagesValid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputPDF;
        private System.Windows.Forms.Button OpenPDFFile;
        private System.Windows.Forms.OpenFileDialog openPDFDialog;
        private System.Windows.Forms.Label fileLocation;
        private System.Windows.Forms.SaveFileDialog savePDFDialog;
        private System.Windows.Forms.Label outputPDF;
        private System.Windows.Forms.Label outFileLocation;
        private System.Windows.Forms.Button SavePDFFile;
        private System.Windows.Forms.Label pageSelector;
        private System.Windows.Forms.TextBox pageTXTBox;
        private System.Windows.Forms.PictureBox pagesValid;
        private System.Windows.Forms.Button RunSave;
        private System.Windows.Forms.Label example;
        private System.Windows.Forms.Label titleLabel;
    }
}


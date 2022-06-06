namespace WindowsFormsApp1
{
    partial class PDFTK_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFTK_Editor));
            this.title = new System.Windows.Forms.Label();
            this.cut = new System.Windows.Forms.Button();
            this.encrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Roboto", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(181, 27);
            this.title.TabIndex = 0;
            this.title.Text = "PDFTK GUI Editor";
            // 
            // cut
            // 
            this.cut.Font = new System.Drawing.Font("Roboto", 12F);
            this.cut.Location = new System.Drawing.Point(12, 59);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(190, 30);
            this.cut.TabIndex = 1;
            this.cut.Text = "Cut PDF Pages";
            this.cut.UseVisualStyleBackColor = true;
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // encrypt
            // 
            this.encrypt.Font = new System.Drawing.Font("Roboto", 12F);
            this.encrypt.Location = new System.Drawing.Point(12, 95);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(190, 30);
            this.encrypt.TabIndex = 2;
            this.encrypt.Text = "Encrypt PDF";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // PDFTK_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 361);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.cut);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PDFTK_Editor";
            this.Text = "PDFTK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button cut;
        private System.Windows.Forms.Button encrypt;
    }
}
namespace SPFileExporter
{
    partial class frmMain
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
            this.lblSiteURL = new System.Windows.Forms.Label();
            this.txtSiteURL = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cboDocumentLibrary = new System.Windows.Forms.ComboBox();
            this.lblDocumentLibrary = new System.Windows.Forms.Label();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.saveFolderBrowseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDownloadFiles = new System.Windows.Forms.Button();
            this.ckSelectAllFiles = new System.Windows.Forms.CheckBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSiteURL
            // 
            this.lblSiteURL.AutoSize = true;
            this.lblSiteURL.Location = new System.Drawing.Point(56, 26);
            this.lblSiteURL.Name = "lblSiteURL";
            this.lblSiteURL.Size = new System.Drawing.Size(50, 13);
            this.lblSiteURL.TabIndex = 0;
            this.lblSiteURL.Text = "Site URL";
            // 
            // txtSiteURL
            // 
            this.txtSiteURL.Location = new System.Drawing.Point(112, 23);
            this.txtSiteURL.Name = "txtSiteURL";
            this.txtSiteURL.Size = new System.Drawing.Size(406, 20);
            this.txtSiteURL.TabIndex = 2;
            this.txtSiteURL.Text = "http://localhost/";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(524, 21);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cboDocumentLibrary
            // 
            this.cboDocumentLibrary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocumentLibrary.FormattingEnabled = true;
            this.cboDocumentLibrary.Location = new System.Drawing.Point(112, 49);
            this.cboDocumentLibrary.Name = "cboDocumentLibrary";
            this.cboDocumentLibrary.Size = new System.Drawing.Size(406, 21);
            this.cboDocumentLibrary.TabIndex = 4;
            this.cboDocumentLibrary.SelectedIndexChanged += new System.EventHandler(this.cboDocumentLibrary_SelectedIndexChanged);
            // 
            // lblDocumentLibrary
            // 
            this.lblDocumentLibrary.AutoSize = true;
            this.lblDocumentLibrary.Location = new System.Drawing.Point(16, 56);
            this.lblDocumentLibrary.Name = "lblDocumentLibrary";
            this.lblDocumentLibrary.Size = new System.Drawing.Size(90, 13);
            this.lblDocumentLibrary.TabIndex = 5;
            this.lblDocumentLibrary.Text = "Document Library";
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(112, 109);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstFiles.Size = new System.Drawing.Size(406, 225);
            this.lstFiles.TabIndex = 6;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            // 
            // lblSavePath
            // 
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.Location = new System.Drawing.Point(49, 81);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(57, 13);
            this.lblSavePath.TabIndex = 7;
            this.lblSavePath.Text = "Save Path";
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(112, 78);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.ReadOnly = true;
            this.txtSavePath.Size = new System.Drawing.Size(406, 20);
            this.txtSavePath.TabIndex = 8;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(524, 76);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnDownloadFiles
            // 
            this.btnDownloadFiles.Location = new System.Drawing.Point(112, 414);
            this.btnDownloadFiles.Name = "btnDownloadFiles";
            this.btnDownloadFiles.Size = new System.Drawing.Size(406, 23);
            this.btnDownloadFiles.TabIndex = 10;
            this.btnDownloadFiles.Text = "Download Selected Files";
            this.btnDownloadFiles.UseVisualStyleBackColor = true;
            this.btnDownloadFiles.Click += new System.EventHandler(this.btnDownloadFiles_Click);
            // 
            // ckSelectAllFiles
            // 
            this.ckSelectAllFiles.AutoSize = true;
            this.ckSelectAllFiles.Location = new System.Drawing.Point(112, 341);
            this.ckSelectAllFiles.Name = "ckSelectAllFiles";
            this.ckSelectAllFiles.Size = new System.Drawing.Size(94, 17);
            this.ckSelectAllFiles.TabIndex = 11;
            this.ckSelectAllFiles.Text = "Select All Files";
            this.ckSelectAllFiles.UseVisualStyleBackColor = true;
            this.ckSelectAllFiles.CheckedChanged += new System.EventHandler(this.ckSelectAllFiles_CheckedChanged);
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtError.Location = new System.Drawing.Point(112, 365);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtError.Size = new System.Drawing.Size(406, 43);
            this.txtError.TabIndex = 12;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(63, 368);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(43, 13);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "Error (s)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 451);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.ckSelectAllFiles);
            this.Controls.Add(this.btnDownloadFiles);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.lblSavePath);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.lblDocumentLibrary);
            this.Controls.Add(this.cboDocumentLibrary);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtSiteURL);
            this.Controls.Add(this.lblSiteURL);
            this.Name = "frmMain";
            this.Text = "SharePoint File Exporter";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSiteURL;
        private System.Windows.Forms.TextBox txtSiteURL;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cboDocumentLibrary;
        private System.Windows.Forms.Label lblDocumentLibrary;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Label lblSavePath;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog saveFolderBrowseDialog;
        private System.Windows.Forms.Button btnDownloadFiles;
        private System.Windows.Forms.CheckBox ckSelectAllFiles;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label lblError;
    }
}


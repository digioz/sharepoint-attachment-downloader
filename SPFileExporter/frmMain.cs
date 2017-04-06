using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPFileExporter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to enable and disable the download
        /// button based on the number of items available 
        /// in the file list control
        /// </summary>
        private void EnableDisableDownloadButton()
        {
            if (lstFiles.Items.Count > 0 && lstFiles.SelectedItems.Count > 0)
            {
                btnDownloadFiles.Enabled = true;
                ckSelectAllFiles.Enabled = true;
            }
            else
            {
                btnDownloadFiles.Enabled = false;
                ckSelectAllFiles.Enabled = false;
            }
        }

        /// <summary>
        /// Method to select all items in the 
        /// Files Listbox
        /// </summary>
        private void SelectAllItemsInFileList()
        {
            if (ckSelectAllFiles.Checked)
            {
                for (int i = 0; i < lstFiles.Items.Count; i++)
                {
                    lstFiles.SetSelected(i, true);
                }
            }
            else
            {
                for (int i = 0; i < lstFiles.Items.Count; i++)
                {
                    lstFiles.SetSelected(i, false);
                }
            }
        }

        /// <summary>
        /// Main Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            btnDownloadFiles.Enabled = false;
            ckSelectAllFiles.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                string sitePath = txtSiteURL.Text;
                cboDocumentLibrary.Items.Clear();

                SPSite siteCollection = new SPSite(sitePath);
                SPWeb site = siteCollection.RootWeb;

                txtSiteURL.Text = siteCollection.Url.ToString() + "/";
                sitePath = txtSiteURL.Text;

                foreach (SPList list in site.Lists)
                {
                    if (list.BaseType.ToString() == "DocumentLibrary")
                    {
                        cboDocumentLibrary.Items.Add(list.Title);
                    }
                }

                if (cboDocumentLibrary.Items.Count > 0)
                {
                    cboDocumentLibrary.SelectedIndex = 1;
                }

                site.Dispose();
                siteCollection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            Cursor.Current = Cursors.Default;
        }

        private void cboDocumentLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFiles.Items.Clear();
            string sitePath = txtSiteURL.Text;
            txtError.Text = string.Empty;
            SPSite siteCollection = new SPSite(sitePath);
            SPWeb site = siteCollection.RootWeb;

            SPDocumentLibrary documentLibrary = (SPDocumentLibrary)site.Lists[cboDocumentLibrary.Text];

            foreach (SPListItem item in documentLibrary.Items)
            {
                lstFiles.Items.Add(item.File.ToString());
            }

            EnableDisableDownloadButton();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            saveFolderBrowseDialog.ShowDialog();
            txtSavePath.Text = saveFolderBrowseDialog.SelectedPath + "\\";
        }

        private void btnDownloadFiles_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtSavePath.Text))
            {
                Cursor.Current = Cursors.WaitCursor;

                bool result = false; 

                foreach (var item in lstFiles.SelectedItems)
                {
                    result = SPHelper.DownloadFile(txtSiteURL.Text, item.ToString(), txtSavePath.Text);

                    if (result == false)
                    {
                        txtError.Text += item.ToString() + Environment.NewLine;
                    }
                }

                if (result)
                {
                    MessageBox.Show("File(s) downloaded successfully!");
                }
                else
                {
                    MessageBox.Show("One or more Files failed to downloaded!");
                }

                btnDownloadFiles.Enabled = false;
                ckSelectAllFiles.Checked = false;
                lstFiles.SelectedItems.Clear();

                Cursor.Current = Cursors.Default;
            }
            else
            {
                MessageBox.Show("Please specify a download directory!");
            }
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableDisableDownloadButton();
        }

        private void ckSelectAllFiles_CheckedChanged(object sender, EventArgs e)
        {
            SelectAllItemsInFileList();
        }


    }
}

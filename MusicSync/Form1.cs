using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace MusicSync
{
    public partial class Form1 : Form
    {
        private FTPManager ftpManager;
        public String[] LocalFiles;
        public String[] RemoteFiles;

        public List<String> UploadFiles;
        public List<String> DownloadFiles;

        public Form1()
        {
            InitializeComponent();

            UploadFiles = new List<string>();
            DownloadFiles = new List<string>();

            localDirectoryTF.Text = Config.DefaultLocalDir;
            LoadLocalDirectoryList();

            ftpManager = new FTPManager();

            LoadServerDirectoryList();
        }

        private void LoadLocalDirectoryList()
        {
            if (localDirectoryTF.Text.Length == 0)
            {
                return;
            }
            localListBox.Items.Clear();

            try
            {
                LocalFiles = Directory.GetFiles(localDirectoryTF.Text);
                foreach (String fileName in LocalFiles)
                {
                    String ShortName = Path.GetFileName(fileName);
                    if (ShortName.Length < 3) { continue; }
                    ListViewItem item = new ListViewItem(ShortName, 1);
                    localListBox.Items.Add(item);
                }
                GetDiff();
            }
            catch (Exception) { }
        }

        private void LoadServerDirectoryList()
        {
            serverListBox.Items.Clear();
            try
            {
                RemoteFiles = ftpManager.GetFileList();
                foreach (String fileName in RemoteFiles)
                {
                    if (fileName.Length < 3) { continue; }
                    ListViewItem item = new ListViewItem(fileName, 1);

                    serverListBox.Items.Add(item);
                }
                GetDiff();
            }
            catch (Exception e) 
            {
                System.Diagnostics.Debug.WriteLine("ERROR: " + e.Message);
                MessageBox.Show("ERROR: Could not connect to Server. " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshLocalBtn_Click(object sender, EventArgs e)
        {
                LoadLocalDirectoryList();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = localDirectoryTF.Text;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                localDirectoryTF.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void refreshServerBtn_Click(object sender, EventArgs e)
        {
            LoadServerDirectoryList();
        }

        private void GetDiff()
        {
            UploadFiles.Clear();
            DownloadFiles.Clear();

            foreach (String locFile in LocalFiles)
            {
                String ShortName = Path.GetFileName(locFile);
                if (!RemoteFiles.Contains(ShortName))
                {
                    UploadFiles.Add(locFile);
                }
            }

            foreach (String remoteFile in RemoteFiles)
            {
                if (!LocalFiles.Select(Path.GetFileName).Contains(remoteFile))
                {
                    DownloadFiles.Add(remoteFile);
                }
            }
        }

        private void syncBtn_Click(object sender, EventArgs e)
        {
            if (!ftpTransferWorker.IsBusy)
            {
                ftpTransferWorker.RunWorkerAsync();
            }
        }

        private void viewDiffBtn_Click(object sender, EventArgs e)
        {
            DiffForm diffForm = new DiffForm(UploadFiles.ToArray(), DownloadFiles.ToArray());
            diffForm.Show();
        }

        private void ftpTransferWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i=0;
            foreach (String upFile in UploadFiles)
            {
                ftpManager.UploadFile(upFile, this);
                i++;
                ftpTransferWorker.ReportProgress((int)(((double)i / (double)UploadFiles.Count) * 100), "Sync");
            }   
        }

        private void ftpTransferWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState == "Sync")
            {
                syncProgressBar.Value = e.ProgressPercentage;
            }
            else if (e.UserState == "File")
            {
                fileProgressBar.Value = e.ProgressPercentage;
            }
            System.Diagnostics.Debug.WriteLine(e.ProgressPercentage + " __ " + e.UserState);
        }

        private void ftpTransferWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
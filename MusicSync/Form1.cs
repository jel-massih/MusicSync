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
                LocalFiles = Directory.EnumerateFiles(localDirectoryTF.Text).Select(Path.GetFileName).ToArray();
                foreach (String fileName in LocalFiles)
                {
                    if (fileName.Length < 3) { continue; }
                    ListViewItem item = new ListViewItem(fileName, 1);
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
                if (!RemoteFiles.Contains(locFile))
                {
                    UploadFiles.Add(locFile);
                }
            }

            foreach (String remoteFile in RemoteFiles)
            {
                if (!LocalFiles.Contains(remoteFile))
                {
                    DownloadFiles.Add(remoteFile);
                }
            }
        }

        private void syncBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewDiffBtn_Click(object sender, EventArgs e)
        {
            DiffForm diffForm = new DiffForm(UploadFiles.ToArray(), DownloadFiles.ToArray());
            diffForm.Show();
        }
    }
}
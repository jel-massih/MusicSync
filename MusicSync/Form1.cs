using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace MusicSync
{
    public partial class Form1 : Form
    {
        private FTPManager ftpManager;
        public String[] LocalFiles;
        public String[] RemoteFiles;

        public Form1()
        {
            InitializeComponent();

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

            try
            {
                LocalFiles = Directory.EnumerateFiles(localDirectoryTF.Text).Select(Path.GetFileName).ToArray();
                localListBox.Clear();
                localListBox.BeginUpdate();
                foreach (String fileName in LocalFiles)
                {
                    ListViewItem item = new ListViewItem(fileName, 1);
                    localListBox.Items.Add(item);
                }
                localListBox.EndUpdate();
            }
            catch (Exception) { }
        }

        private void LoadServerDirectoryList()
        {
            try
            {
                serverListBox.Clear();
                serverListBox.BeginUpdate();
                RemoteFiles = ftpManager.GetFileList();
                foreach (String fileName in RemoteFiles)
                {
                    ListViewItem item = new ListViewItem(fileName, 1);

                    serverListBox.Items.Add(item);
                }
                serverListBox.EndUpdate();
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
    }
}

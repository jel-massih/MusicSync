using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MusicSync
{
    public partial class Form1 : Form
    {
        private FTPManager ftpManager;

        public Form1()
        {
            InitializeComponent();

            ftpManager = new FTPManager();

            LoadLocalDirectoryList();
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
                String[] directoryFiles = Directory.GetFiles(localDirectoryTF.Text);
                localListBox.BeginUpdate();
                foreach (String fileName in directoryFiles)
                {
                    localListBox.Items.Add(fileName);
                }
                localListBox.EndUpdate();
            }
            catch (Exception) { }
        }

        private void LoadServerDirectoryList()
        {
            if (serverAddressTF.Text.Length == 0)
            {
                return;
            }

            try
            {
                ftpManager.UpdateRequestPath(serverAddressTF.Text);

                serverListBox.BeginUpdate();
                foreach (String fileName in ftpManager.GetFileList())
                {
                    serverListBox.Items.Add(fileName);
                }
                serverListBox.EndUpdate();
            }
            catch (Exception) { }
        }
    }
}

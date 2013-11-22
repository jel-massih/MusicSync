namespace MusicSync
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.localListBox = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.browseBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.localDirectoryTF = new System.Windows.Forms.TextBox();
            this.syncBtn = new System.Windows.Forms.Button();
            this.syncInfoLbl = new System.Windows.Forms.Label();
            this.refreshServerBtn = new System.Windows.Forms.Button();
            this.refreshLocalBtn = new System.Windows.Forms.Button();
            this.syncProgressBar = new System.Windows.Forms.ProgressBar();
            this.serverListBox = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.viewDiffBtn = new System.Windows.Forms.Button();
            this.ftpTransferWorker = new System.ComponentModel.BackgroundWorker();
            this.fileProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // localListBox
            // 
            this.localListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.localListBox.Location = new System.Drawing.Point(543, 37);
            this.localListBox.Margin = new System.Windows.Forms.Padding(2);
            this.localListBox.Name = "localListBox";
            this.localListBox.Size = new System.Drawing.Size(532, 318);
            this.localListBox.TabIndex = 1;
            this.localListBox.UseCompatibleStateImageBehavior = false;
            this.localListBox.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 600;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Local";
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(907, 362);
            this.browseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(64, 19);
            this.browseBtn.TabIndex = 9;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Local Directory:";
            // 
            // localDirectoryTF
            // 
            this.localDirectoryTF.Location = new System.Drawing.Point(626, 362);
            this.localDirectoryTF.Margin = new System.Windows.Forms.Padding(2);
            this.localDirectoryTF.Name = "localDirectoryTF";
            this.localDirectoryTF.Size = new System.Drawing.Size(278, 20);
            this.localDirectoryTF.TabIndex = 7;
            // 
            // syncBtn
            // 
            this.syncBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.syncBtn.Location = new System.Drawing.Point(12, 424);
            this.syncBtn.Margin = new System.Windows.Forms.Padding(2);
            this.syncBtn.Name = "syncBtn";
            this.syncBtn.Size = new System.Drawing.Size(70, 32);
            this.syncBtn.TabIndex = 11;
            this.syncBtn.Text = "Sync";
            this.syncBtn.UseVisualStyleBackColor = true;
            this.syncBtn.Click += new System.EventHandler(this.syncBtn_Click);
            // 
            // syncInfoLbl
            // 
            this.syncInfoLbl.AutoSize = true;
            this.syncInfoLbl.BackColor = System.Drawing.Color.Transparent;
            this.syncInfoLbl.Location = new System.Drawing.Point(94, 433);
            this.syncInfoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.syncInfoLbl.Name = "syncInfoLbl";
            this.syncInfoLbl.Size = new System.Drawing.Size(52, 13);
            this.syncInfoLbl.TabIndex = 12;
            this.syncInfoLbl.Text = "Sync Info";
            // 
            // refreshServerBtn
            // 
            this.refreshServerBtn.Location = new System.Drawing.Point(462, 16);
            this.refreshServerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshServerBtn.Name = "refreshServerBtn";
            this.refreshServerBtn.Size = new System.Drawing.Size(64, 19);
            this.refreshServerBtn.TabIndex = 13;
            this.refreshServerBtn.Text = "Refresh";
            this.refreshServerBtn.UseVisualStyleBackColor = true;
            this.refreshServerBtn.Click += new System.EventHandler(this.refreshServerBtn_Click);
            // 
            // refreshLocalBtn
            // 
            this.refreshLocalBtn.Location = new System.Drawing.Point(1010, 16);
            this.refreshLocalBtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshLocalBtn.Name = "refreshLocalBtn";
            this.refreshLocalBtn.Size = new System.Drawing.Size(64, 19);
            this.refreshLocalBtn.TabIndex = 14;
            this.refreshLocalBtn.Text = "Refresh";
            this.refreshLocalBtn.UseVisualStyleBackColor = true;
            this.refreshLocalBtn.Click += new System.EventHandler(this.refreshLocalBtn_Click);
            // 
            // syncProgressBar
            // 
            this.syncProgressBar.Location = new System.Drawing.Point(86, 424);
            this.syncProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.syncProgressBar.Name = "syncProgressBar";
            this.syncProgressBar.Size = new System.Drawing.Size(885, 32);
            this.syncProgressBar.TabIndex = 10;
            // 
            // serverListBox
            // 
            this.serverListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.serverListBox.Location = new System.Drawing.Point(15, 38);
            this.serverListBox.Margin = new System.Windows.Forms.Padding(2);
            this.serverListBox.Name = "serverListBox";
            this.serverListBox.Size = new System.Drawing.Size(511, 318);
            this.serverListBox.TabIndex = 15;
            this.serverListBox.UseCompatibleStateImageBehavior = false;
            this.serverListBox.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 600;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // viewDiffBtn
            // 
            this.viewDiffBtn.Location = new System.Drawing.Point(15, 362);
            this.viewDiffBtn.Name = "viewDiffBtn";
            this.viewDiffBtn.Size = new System.Drawing.Size(131, 23);
            this.viewDiffBtn.TabIndex = 16;
            this.viewDiffBtn.Text = "View Diff";
            this.viewDiffBtn.UseVisualStyleBackColor = true;
            this.viewDiffBtn.Click += new System.EventHandler(this.viewDiffBtn_Click);
            // 
            // ftpTransferWorker
            // 
            this.ftpTransferWorker.WorkerReportsProgress = true;
            this.ftpTransferWorker.WorkerSupportsCancellation = true;
            this.ftpTransferWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ftpTransferWorker_DoWork);
            this.ftpTransferWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ftpTransferWorker_ProgressChanged);
            this.ftpTransferWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ftpTransferWorker_RunWorkerCompleted);
            // 
            // fileProgressBar
            // 
            this.fileProgressBar.Location = new System.Drawing.Point(86, 392);
            this.fileProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.fileProgressBar.Name = "fileProgressBar";
            this.fileProgressBar.Size = new System.Drawing.Size(885, 23);
            this.fileProgressBar.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 467);
            this.Controls.Add(this.fileProgressBar);
            this.Controls.Add(this.viewDiffBtn);
            this.Controls.Add(this.serverListBox);
            this.Controls.Add(this.refreshLocalBtn);
            this.Controls.Add(this.refreshServerBtn);
            this.Controls.Add(this.syncInfoLbl);
            this.Controls.Add(this.syncBtn);
            this.Controls.Add(this.syncProgressBar);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.localDirectoryTF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.localListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView localListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox localDirectoryTF;
        private System.Windows.Forms.Button syncBtn;
        private System.Windows.Forms.Label syncInfoLbl;
        private System.Windows.Forms.Button refreshServerBtn;
        private System.Windows.Forms.Button refreshLocalBtn;
        private System.Windows.Forms.ProgressBar syncProgressBar;
        private System.Windows.Forms.ListView serverListBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button viewDiffBtn;
        private System.Windows.Forms.ProgressBar fileProgressBar;
        public System.ComponentModel.BackgroundWorker ftpTransferWorker;
    }
}


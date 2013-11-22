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
            this.serverListBox = new System.Windows.Forms.ListView();
            this.localListBox = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serverAddressTF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.testBtn = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.localDirectoryTF = new System.Windows.Forms.TextBox();
            this.syncProgressBar = new System.Windows.Forms.ProgressBar();
            this.syncBtn = new System.Windows.Forms.Button();
            this.syncInfoLbl = new System.Windows.Forms.Label();
            this.refreshServerBtn = new System.Windows.Forms.Button();
            this.refreshLocalBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverListBox
            // 
            this.serverListBox.Location = new System.Drawing.Point(12, 46);
            this.serverListBox.Name = "serverListBox";
            this.serverListBox.Size = new System.Drawing.Size(708, 391);
            this.serverListBox.TabIndex = 0;
            this.serverListBox.UseCompatibleStateImageBehavior = false;
            // 
            // localListBox
            // 
            this.localListBox.Location = new System.Drawing.Point(724, 46);
            this.localListBox.Name = "localListBox";
            this.localListBox.Size = new System.Drawing.Size(708, 391);
            this.localListBox.TabIndex = 1;
            this.localListBox.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Local";
            // 
            // serverAddressTF
            // 
            this.serverAddressTF.Location = new System.Drawing.Point(129, 445);
            this.serverAddressTF.Name = "serverAddressTF";
            this.serverAddressTF.Size = new System.Drawing.Size(369, 22);
            this.serverAddressTF.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Server Address:";
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(504, 445);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(86, 23);
            this.testBtn.TabIndex = 6;
            this.testBtn.Text = "Test";
            this.testBtn.UseVisualStyleBackColor = true;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(1209, 445);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(86, 23);
            this.browseBtn.TabIndex = 9;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(721, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Local Directory:";
            // 
            // localDirectoryTF
            // 
            this.localDirectoryTF.Location = new System.Drawing.Point(834, 445);
            this.localDirectoryTF.Name = "localDirectoryTF";
            this.localDirectoryTF.Size = new System.Drawing.Size(369, 22);
            this.localDirectoryTF.TabIndex = 7;
            // 
            // syncProgressBar
            // 
            this.syncProgressBar.Location = new System.Drawing.Point(115, 499);
            this.syncProgressBar.Name = "syncProgressBar";
            this.syncProgressBar.Size = new System.Drawing.Size(1180, 39);
            this.syncProgressBar.TabIndex = 10;
            // 
            // syncBtn
            // 
            this.syncBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.syncBtn.Location = new System.Drawing.Point(16, 499);
            this.syncBtn.Name = "syncBtn";
            this.syncBtn.Size = new System.Drawing.Size(93, 39);
            this.syncBtn.TabIndex = 11;
            this.syncBtn.Text = "Sync";
            this.syncBtn.UseVisualStyleBackColor = true;
            // 
            // syncInfoLbl
            // 
            this.syncInfoLbl.AutoSize = true;
            this.syncInfoLbl.BackColor = System.Drawing.Color.Transparent;
            this.syncInfoLbl.Location = new System.Drawing.Point(126, 510);
            this.syncInfoLbl.Name = "syncInfoLbl";
            this.syncInfoLbl.Size = new System.Drawing.Size(66, 17);
            this.syncInfoLbl.TabIndex = 12;
            this.syncInfoLbl.Text = "Sync Info";
            // 
            // refreshServerBtn
            // 
            this.refreshServerBtn.Location = new System.Drawing.Point(616, 20);
            this.refreshServerBtn.Name = "refreshServerBtn";
            this.refreshServerBtn.Size = new System.Drawing.Size(86, 23);
            this.refreshServerBtn.TabIndex = 13;
            this.refreshServerBtn.Text = "Refresh";
            this.refreshServerBtn.UseVisualStyleBackColor = true;
            // 
            // refreshLocalBtn
            // 
            this.refreshLocalBtn.Location = new System.Drawing.Point(1346, 20);
            this.refreshLocalBtn.Name = "refreshLocalBtn";
            this.refreshLocalBtn.Size = new System.Drawing.Size(86, 23);
            this.refreshLocalBtn.TabIndex = 14;
            this.refreshLocalBtn.Text = "Refresh";
            this.refreshLocalBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 556);
            this.Controls.Add(this.refreshLocalBtn);
            this.Controls.Add(this.refreshServerBtn);
            this.Controls.Add(this.syncInfoLbl);
            this.Controls.Add(this.syncBtn);
            this.Controls.Add(this.syncProgressBar);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.localDirectoryTF);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serverAddressTF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.localListBox);
            this.Controls.Add(this.serverListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView serverListBox;
        private System.Windows.Forms.ListView localListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverAddressTF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox localDirectoryTF;
        private System.Windows.Forms.ProgressBar syncProgressBar;
        private System.Windows.Forms.Button syncBtn;
        private System.Windows.Forms.Label syncInfoLbl;
        private System.Windows.Forms.Button refreshServerBtn;
        private System.Windows.Forms.Button refreshLocalBtn;
    }
}


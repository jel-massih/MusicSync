using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicSync
{
    public partial class DiffForm : Form
    {

        public DiffForm(String[] uploadFiles, String[] downloadFiles)
        {
            InitializeComponent();

            foreach (String locFile in uploadFiles)
            {
                uploadView.Items.Add(new ListViewItem(locFile, 1));
            }

            foreach (String serverFile in downloadFiles)
            {
                downloadView.Items.Add(new ListViewItem(serverFile, 1));
            }
        }
    }
}

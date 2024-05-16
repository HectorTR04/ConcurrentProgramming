using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBackup
{
    public partial class MainForm : Form
    {
        FileBackupThreadPool fileBackupPool;
        FileBackupAsync fileBackupAsync;
        public MainForm()
        {
            InitializeComponent();
            lstSource.Items.Clear();
            lstTarget.Items.Clear();
            fileBackupPool = new FileBackupThreadPool(this);
            fileBackupAsync = new FileBackupAsync(this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string[] filePaths = fileBackupPool.GetFilePaths();
            if (filePaths != null)
            {
                fileBackupPool.Start();
            }
        }

        private void btnAsync_Click(object sender, EventArgs e)
        {
            Task getFilePaths = Task.Run( async () =>
            {
                getFilePaths = fileBackupAsync.GetFilePaths();
            });
               
            if (getFilePaths != null)
            {
                fileBackupAsync.Start();
            }         
        }
    }
}


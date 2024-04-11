using System;
using System.Windows.Forms;

namespace BankingSystem
{
    public partial class MainForm : Form
    {
        private BankManager bankManager;

        public MainForm()
        {
            InitializeComponent();
            bankManager = new BankManager(this);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           bankManager.CreateThreads();
           bankManager.managerThread.Start();
        }

        public void UpdateResults(string item)
        {
            if (ListResult.InvokeRequired)
            {
                ListResult.Invoke(new Action<string>(UpdateResults), item);
            }
            else
            {              
                ListResult.Items.Add(item);
            }
        }

        public void UpdateQueue(string item)
        {
            if (ListOutput.InvokeRequired)
            {
                ListOutput.Invoke(new Action<string>(UpdateQueue), item);
            }
            else
            {
                ListOutput.Items.Add(item);
            }
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            bankManager.StopClients();
            bankManager.IsRunning = false;
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

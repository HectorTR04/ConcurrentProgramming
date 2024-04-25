using System;
using System.Windows.Forms;

namespace LogisticManagementSystem
{
    public partial class MainForm : Form
    {
        private LogisticManager logisticManager;
        private Storage<Product> storage;

        public MainForm()
        {
            InitializeComponent();
            logisticManager = new LogisticManager(this);
            storage = logisticManager.Storage;
        }

    private void StartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.Start();
            logisticManager.managerThread.Start();
            lantmannenStartBtn.Enabled = true;
            razerStartBtn.Enabled = true;
            bOSCHStartBtn.Enabled = true;
            icaStartBtn.Enabled = true;
            elgigantenStartBtn.Enabled = true;
            clasOhlsonStartBtn.Enabled = true;
        }

        private void LantmannenStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartProducer(Product.CategoryType.Food);
            lantmannenStatus.Text = ConstStrings.PRODUCING;
            lantmannenStartBtn.Enabled = false;
            lantmannenStopBtn.Enabled = true;
        }

        private void LantmannenStopBtn_Click(object sender, EventArgs e)
        {
           logisticManager.StopProducer(Product.CategoryType.Food);
           lantmannenStatus.Text = ConstStrings.NOT_PRODUCING;
           lantmannenStartBtn.Enabled = true;
           lantmannenStopBtn.Enabled = false; 
        }

        private void RazerStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartProducer(Product.CategoryType.Electronics);
            razerStatus.Text = ConstStrings.PRODUCING;
            razerStartBtn.Enabled = false;
            razerStopBtn.Enabled = true;
        }

        private void RazerStopBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StopProducer(Product.CategoryType.Electronics);
            razerStatus.Text = ConstStrings.NOT_PRODUCING;
            razerStartBtn.Enabled = true;
            razerStopBtn.Enabled = false;
        }

        private void BOSCHStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartProducer(Product.CategoryType.Tools);
            bOSCHStatus.Text = ConstStrings.PRODUCING;
            bOSCHStartBtn.Enabled = false;
            bOSCHStopBtn.Enabled = true;
        }

        private void BOSCHStopBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StopProducer(Product.CategoryType.Tools);
            bOSCHStatus.Text = ConstStrings.NOT_PRODUCING;
            bOSCHStartBtn.Enabled = true;
            bOSCHStopBtn.Enabled = false;
        }

        private void IcaStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartConsumer(Product.CategoryType.Food);
            icaStatus.Text = ConstStrings.CONSUMING;
            icaStartBtn.Enabled = false;
            icaStopButton.Enabled = true;
        }

        private void IcaStopButton_Click(object sender, EventArgs e)
        {
           logisticManager.StopConsumer(Product.CategoryType.Food);
           icaStatus.Text = ConstStrings.NOT_CONSUMING;
           icaStartBtn.Enabled = true;
           icaStopButton.Enabled = false;
        }

        private void ElgigantenStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartConsumer(Product.CategoryType.Electronics);
            elgigantenStatus.Text = ConstStrings.CONSUMING;
            elgigantenStartBtn.Enabled = false;
            elgigantenStopBtn.Enabled = true;
        }

        private void ElgigantenStopBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StopConsumer(Product.CategoryType.Electronics);
            elgigantenStatus.Text = ConstStrings.NOT_CONSUMING;
            elgigantenStartBtn.Enabled = true;
            elgigantenStopBtn.Enabled = false;
        }

        private void ClasOhlsonStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartConsumer(Product.CategoryType.Tools);
            clasOhlsonStatus.Text = ConstStrings.CONSUMING;
            clasOhlsonStartBtn.Enabled = false;
            clasOhlsonStopBtn.Enabled = true;
        }

        private void ClasOhlsonStopBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StopConsumer(Product.CategoryType.Electronics);
            clasOhlsonStatus.Text = ConstStrings.NOT_CONSUMING;
            clasOhlsonStartBtn.Enabled = true;
            clasOhlsonStopBtn.Enabled = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void UpdateIcaProducts(string item)
        {

            if (IcaListBox.InvokeRequired)
            {
                IcaListBox.Invoke(new Action<string>(UpdateIcaProducts), item);
            }
            else
            {
                IcaListBox.Items.Add(item);
            }
        }

        public void UpdateElgigantenProducts(string item)
        {
            if (ElgigantenListBox.InvokeRequired)
            {
                ElgigantenListBox.Invoke(new Action<string>(UpdateElgigantenProducts), item);
            }
            else
            {
                ElgigantenListBox.Items.Add(item);
            }
        }
        public void UpdateClasOhlsonProducts(string item)
        {
            if (ClasOhlsonListbox.InvokeRequired)
            {
                ClasOhlsonListbox.Invoke(new Action<string>(UpdateClasOhlsonProducts), item);
            }
            else
            {
                ClasOhlsonListbox.Items.Add(item);
            }
        }

        public void UpdateProgressBar(int value)
        {
            if (ProgressItems.InvokeRequired)
            {
                ProgressItems.Invoke(new Action<int>(UpdateProgressBar), value);
            }
            else
            {
                ProgressItems.Value = value;
            }
        }
        public void UpdateIcaStatus(bool state)
        {
            if (IcaStatus.InvokeRequired)
            {
                IcaStatus.Invoke(new Action<bool>(UpdateIcaStatus), state);
            }
            else
            {
                if (state)
                {
                    IcaStatus.Text = ConstStrings.CONSUMING;
                }
                else
                {
                    IcaStatus.Text = ConstStrings.WAITING;
                }
            }
        }
        public void UpdateElgigantenStatus(bool state)
        {
            if (ElgigantenStatus.InvokeRequired)
            {
                ElgigantenStatus.Invoke(new Action<bool>(UpdateElgigantenStatus), state);
            }
            else
            {
                if (state)
                {
                    ElgigantenStatus.Text = ConstStrings.CONSUMING;
                }
                else
                {
                    ElgigantenStatus.Text = ConstStrings.WAITING;
                }
            }
        }
        public void UpdateClasOhlsonStatus(bool state)
        {
            if (ClasOhlsonStatus.InvokeRequired)
            {
                ClasOhlsonStatus.Invoke(new Action<bool>(UpdateClasOhlsonStatus), state);
            }
            else
            {
                if (state)
                {
                    ClasOhlsonStatus.Text = ConstStrings.CONSUMING;
                }
                else
                {
                    ClasOhlsonStatus.Text = ConstStrings.WAITING;
                }
            }
        }      
    }
}
//Use the following patter to invoke updating of a control by other threads
//IcaStatus.Invoke((MethodInvoker)(() => IcaStatus.Text = 
//xxThread.IsAlive ? "alive" : "dead"));
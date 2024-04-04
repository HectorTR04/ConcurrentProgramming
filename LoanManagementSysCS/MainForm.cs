namespace LoanManagementSys;

public partial class MainForm : Form
{
    private LoanSystem loanSystem;

    public MainForm()
    {
        InitializeComponent();
        loanSystem = new LoanSystem(this);
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
        loanSystem.StartThreads();
        loanSystem.CreateThreads();
    }

    public void UpdateProducts(string item)
    {
        if (ListItems.InvokeRequired)
        {
            ListItems.Invoke(new Action<string>(UpdateProducts), item);
        }
        else
        {
            ListItems.Items.Add(item);
        }
    }

    public void UpdateEvents(string item)
    {
        if (ListOutput.InvokeRequired)
        {
            ListOutput.Invoke(new Action<string>(UpdateEvents), item);
        }
        else
        {
            ListOutput.Items.Add(item);
        }
    }


    private void btnStop_Click(object sender, EventArgs e)
    {
        loanSystem.StopThreads();
    }


    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {

        Application.Exit();
    }

    private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
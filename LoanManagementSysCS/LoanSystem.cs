using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanManagementSys.Managers;
using LoanManagementSys.Tasks;

namespace LoanManagementSys
{
    /// <summary>
    /// A class which handles creating new tasks and assigning threads to run each task
    /// </summary>
    public class LoanSystem
    {
        public ProductManager productManager;
        public LoanItemManager loanItemManager;
        public MemberManager memberManager;
        UpdateGUI updateGUI;
        AdminTask adminTask;
        LoanTask loanTask;
        ReturnTask returnTask;
        public MainForm mainForm;
        public Thread guiThread;
        public Thread adminThread;
        public Thread loanThread;
        public Thread returnThread;
        public bool stopThreads = false;
        public LoanSystem(MainForm mainForm)
        {
            productManager = new ProductManager();
            memberManager = new MemberManager();
            loanItemManager = new LoanItemManager(productManager, memberManager);
            this.mainForm = mainForm;
            adminTask = new AdminTask(productManager);
            updateGUI = new UpdateGUI(this, mainForm);
            loanTask = new LoanTask(loanItemManager);
            returnTask = new ReturnTask(loanItemManager);
            InitialiseLists();
            CreateThreads(); 
        }
        public void CreateThreads()
        {
            guiThread = new Thread(updateGUI.Run);
            adminThread = new Thread(adminTask.Run);
            loanThread = new Thread(loanTask.Run);
            returnThread = new Thread(returnTask.Run);
            guiThread.Start();
            adminThread.Start();
            loanThread.Start();
            returnThread.Start();
        }

        public void StartThreads()
        {
            adminTask.IsRunning = true;
            updateGUI.IsRunning = true;
            loanTask.IsRunning = true;
            returnTask.IsRunning = true;
        }
        public void StopThreads()
        {
            adminTask.IsRunning = false;
            updateGUI.IsRunning = false;
            loanTask.IsRunning = false;
            returnTask.IsRunning = false;
        }
        public void InitialiseLists()
        {
            productManager.AddTestProducts();
            memberManager.AddTestMember();
        }
    }
}

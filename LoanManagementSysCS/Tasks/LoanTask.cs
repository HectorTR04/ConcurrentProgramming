using LoanManagementSys.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagementSys.Tasks
{
    public class LoanTask : BaseTask
    {
        LoanItemManager loanItemManager;

        public LoanTask(LoanItemManager loanItemManager)
        {
            this.loanItemManager = loanItemManager;
        }

        /// <summary>
        /// This method is run by the thread assigned to perform the task. It requests
        /// adding a LoanItem to the list of LoanItems.
        /// </summary>
        public void Run()
        {
            while (isRunning)
            {
                loanItemManager.AddLoanItem();
                Thread.Sleep(random.Next(4000, 6000));
            }
        }
    }
}

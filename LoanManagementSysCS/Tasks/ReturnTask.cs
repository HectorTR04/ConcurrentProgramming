using LoanManagementSys.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagementSys.Tasks
{
    public class ReturnTask : BaseTask
    {
        LoanItemManager loanItemManager;

        public ReturnTask(LoanItemManager loanItemManager)
        {
            this.loanItemManager = loanItemManager;
        }

        /// <summary>
        /// This method is run by the thread assigned to perform the task. It requests
        /// removing a LoanItem from the LoanItems list and returning the loaned product
        /// back to the product list.
        /// </summary>
        public void Run()
        {
            while (isRunning)
            {
                loanItemManager.RemoveLoanItem();
                Thread.Sleep(random.Next(6000, 15000));
            }
        }
    }
}

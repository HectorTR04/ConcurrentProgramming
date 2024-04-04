using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagementSys.Tasks
{
    /// <summary>
    /// Generic task which allows other tasks to inherit a system random 
    /// and a boolean used to run the task method only while the thread is running.
    /// </summary>
    public abstract class BaseTask
    {
        protected Random random = new Random();
        protected bool isRunning = true;
        public bool IsRunning
        {
            get { return isRunning; }
            set { isRunning = value; }
        }
    }
}

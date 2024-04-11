using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferDeadlock
{
    /// <summary>
    /// Class which holds the two accounts in the system. Creates and starts the threads which perform the transaction from one account 
    /// to another to simulate a deadlock situation and a solution to the problem.
    /// </summary>
    public class Transaction
    {
        Account account1 = new Account();
        Account account2 = new Account();
        Thread thread1;
        Thread thread2;
        Thread thread3;
        Thread thread4;
        bool isRunning = true;
        Mutex bigLock = new Mutex();

        public void StartDeadlockTransaction()
        {
            thread1 = new Thread(() => account1.DeadlockTransfer(account2, 69, "Account1", "Account2"));
            thread2 = new Thread(() => account2.DeadlockTransfer(account1, 69, "Account2", "Account1"));           
            thread1.Start();
            thread2.Start();
        }

        public void StartNoDeadlockTransaction()
        {
            thread3 = new Thread(() => account1.NoDeadlockTransfer(bigLock, account2, 69, "Account1", "Account2"));
            thread4 = new Thread(() => account2.NoDeadlockTransfer(bigLock, account1, 69, "Account2", "Account1"));
            thread3.Start();
            thread4.Start();
        }

        public bool IsRunning { get { return isRunning; } set { isRunning = value; } }
    }
}

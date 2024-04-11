using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankingSystem
{
    /// <summary>
    /// Class which contains methods to log the transaction info of a transaction before and after the transaction is made and check
    /// if the transaction was performed correctly. Collects data for each transaction to display it as strings in the WinForm.
    /// </summary>
    public class Security
    {
        List<LogEntry> transactionHistory = new List<LogEntry>();
        int errors;
        Mutex securityMutex = new Mutex();

        //Method to log the balance of a and client ID before the transaction is made
        public LogEntry LogPreTransaction(double balance, int clientID, string transactionInfo)
        {
            LogEntry logEntry = new LogEntry(balance, clientID, transactionInfo);
            transactionHistory.Add(logEntry);
            return logEntry;
        }

        //Method to log the balance of a and client ID after the transaction is made
        public LogEntry LogPostTransaction(double balance, int clientID, string transactionInfo)
        {
            LogEntry logEntry = new LogEntry(balance, clientID, transactionInfo);
            return logEntry;
        }

        //Method to compare the balances of the pre and post transactions to verify they were done correctly and log and error if not
        public void VerifyLastTransaction(double amount, LogEntry preTransactionEntry, LogEntry postTransactionEntry)
        {
            if ((postTransactionEntry.Balance - preTransactionEntry.Balance) != amount)
            {
                errors++;
            }
        }

        //Method to gather data about each transaction as a string to display it in the WinForm
        public string[] TransactionInfoStrings()
        {
            try
            {
                securityMutex.WaitOne(); //Mutex to make sure that the transaction history is only accessed atomically
                if (transactionHistory.Count == 0)
                {
                    return new string[] { "Transaction History is empty" };
                }

                string[] infoStrings = new string[transactionHistory.Count + 1];

                infoStrings[0] = "Transaction Log";

                for (int i = 0; i < transactionHistory.Count; i++)
                {
                    infoStrings[i + 1] = transactionHistory[i].ToString();
                }
                return infoStrings;
            }
            finally { securityMutex.ReleaseMutex(); }           
        }

        public int Errors { get { return errors; } }

    }
}

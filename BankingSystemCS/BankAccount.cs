using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace BankingSystem
{
    /// <summary>
    /// Class which represents the bank account in the system. Provides the transaction method used by client threads to transfer
    /// money to and from the account. Contains a reference to a security object to compare transaction data and verify transactions.
    /// </summary>
    public class BankAccount
    {
        double balance;
        public Security security;
        int totalTransactions = 0;
        Mutex transactionMutex;

        public BankAccount()
        {
            security = new Security();
            transactionMutex = new Mutex();
        }

        //Method run by client threads to transfer money in and out of the bank account
        public void Transaction(double amount, int clientID, string transactionInfo)
        {
            try
            {   //Mutex to ensure only one client thread can run the method at a time to avoid race conditions
                transactionMutex.WaitOne(); 
                LogEntry preTransactionEntry = security.LogPreTransaction(balance, clientID, transactionInfo); //Log pre transaction data
                balance = balance + amount; //Transfer money to and from the bank account
                totalTransactions++; //Add tp the number of total transactions
                LogEntry postTransactionEntry = security.LogPostTransaction(balance, clientID, transactionInfo); //Log post transaction data
                security.VerifyLastTransaction(amount, preTransactionEntry, postTransactionEntry); //Compare pre and post transaction data
            }
            finally { transactionMutex.ReleaseMutex(); }           
        }
        public double Balance { get { return balance; } set { balance = value; } }
        public int TotalTransactions { get { return totalTransactions; } }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    /// <summary>
    /// Class which holds the information for each transaction performed in the system
    /// </summary>
    public class LogEntry
    {
        readonly int clientID;
        readonly double balance;
        string transactionInfo;

        public LogEntry(double balance, int clientID, string transactionInfo)
        {
            this.clientID = clientID;
            this.balance = balance;
            this.transactionInfo = transactionInfo;
        }

        public int ClientID { get {  return clientID; } }
        public double Balance { get { return balance; } }

        public override string ToString()
        {
            DateTime now = DateTime.Now;
            return $" {now} Client ID:{clientID} {transactionInfo}";
        }
    }
}

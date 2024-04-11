using System;
using System.Threading;

namespace BankingSystem
{
    /// <summary>
    /// Class which represents a client in the system, includes a method to run a transaction on the bank account. Randomises the amount
    /// transferred and if the client will deposit or withdraw from the bank account. Stores the individual ID of the client.
    /// </summary>
    public class Client
    {
        int id;
        BankAccount bankAccount;
        double transactionTotal;
        bool isRunning = true;
        double amount;

        public Client(BankAccount bankAccount)
        {
            this.bankAccount = bankAccount;
        }

        //Method which randomly generates an amount to either deposit or withdraw to the bank account and performs the transaction to the 
        //bank account. Provides information about the amount and if there was a deposit or withdrawal in string form.
        public void Run()
        {
            Random random = new Random();
            //Method to randomly generate an amount and whether the client deposits or withdraws from the bank account
            double TransactionAmount()
            {
                int transactionType = random.Next(0, 2);
                if (transactionType == 0) //Client deposits money
                {
                    double amount = random.Next(1000, 5000);
                    return amount;
                }
                else //Client withdraws money
                {
                    double amount = random.Next(-5000, -1000);
                    return amount;
                }
            }
            while (isRunning)
            {
                amount = TransactionAmount();
                string transactionInfo = amount >= 0 ? $"Deposited: {amount}$" : $"Withdrew: {Math.Abs(amount)}$";
                bankAccount.Transaction(amount, id, transactionInfo); //Transaction to the bank account is performed
                transactionTotal += amount; //The transaction amount is added to the client's individual transaction total
                Thread.Sleep(random.Next(1000,5000));
            }
        }
        public int ID { get { return id; } set { id = value; } }       
        public double TransactionTotal { get { return transactionTotal; } }
        public bool IsRunning { get { return isRunning; } set { isRunning = value; } }
    }
}

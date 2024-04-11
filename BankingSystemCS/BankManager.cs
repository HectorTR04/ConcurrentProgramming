using System;
using System.Collections.Generic;
using System.Threading;
namespace BankingSystem
{
    /// <summary>
    /// Class which manages a list of clients and a bank account. Creates the threads used in the application to transfer money from the
    /// clients to the bank account. Includes methods to gather data about all transactions of clients, the balance of the bank account
    /// and how many transactions potentially become errors due to race conditions.
    /// </summary>
    public class BankManager
    {
        BankAccount bankAccount = new BankAccount();
        List<Client> clients = new List<Client>();
        public Thread clientThread;
        public Thread managerThread;
        bool isRunning = true;
        MainForm mainForm;
        public BankManager(MainForm mainForm)
        {
            this.mainForm = mainForm;   
        }

        public bool IsRunning { get { return isRunning; } set { isRunning = value; } } //Bool used to stop and start threads

        //Method which creates client threads which run the transaction method and the manager thread which collects data
        public void CreateThreads() 
        {
            for (int i = 0; i < 10; i++)
            {
                Client newClient = new Client(bankAccount);
                clients.Add(newClient);
            }
            int id = 0;
            foreach (Client client in clients)
            {
                client.ID = id++;
                Thread clientThread = new Thread(client.Run);
                clientThread.Start();
            }
            managerThread = new Thread(this.Run);
        }

        //Method to stop running the client threads to collect data once he program should stop running
        public void StopClients() 
        {
            foreach (Client client in clients)
            {
                client.IsRunning = false;
            }
        }

        //Method which calculates the transaction total for all the clients in the program
        public double ComputeClientTotal()
        {
            double result = 0;
            foreach (Client client in clients)
            {
                result += client.TransactionTotal;
            }
            return result;
        }

        //Method which collects data about the total amount of transactions, errors, client total transaction value and bank account balance
        public string[] ResultsInfoString()
        {
            double clientTotal = ComputeClientTotal();
            string[] infoString = new string[4];

            infoString[0] = $"Total transactions: {bankAccount.TotalTransactions}";
            infoString[1] = $"Number of errors: {bankAccount.security.Errors}";
            infoString[2] = $"Total transaction amount of all clients: {clientTotal}$";
            infoString[3] = $"Balance on account: {bankAccount.Balance}$";

            return infoString;
        }

        //Method which collects data for each individual transaction to display in the event log
        public string[] GetTransactionInfoString()
        {
            string[] infoStrings = bankAccount.security.TransactionInfoStrings();
            return infoStrings;
        }
 
        //Method which is run by the manager thread to update the listboxes in the WinForm application
        public void Run()
        {
            while (isRunning)
            {
                UpdateResultListBox();
                UpdateQueueListBox();
                Thread.Sleep(1000);
            }
        }

        //Method which updates the result list box which contains the results of the client transfers
        public void UpdateResultListBox()
        {
            string[] infoString = ResultsInfoString();

            if (mainForm.ListResult.InvokeRequired)
            {
                mainForm.ListResult.Invoke(new Action(UpdateResultListBox));
            }
            else
            {
                ClearResultListBox();
                foreach(string resultString in infoString)
                {
                    mainForm.UpdateResults(resultString);
                }
            }
        }

        //Method which updates the queue list box which contains the a log of each client transaction
        public void UpdateQueueListBox()
        {
            string[] infoString = GetTransactionInfoString();

            if (mainForm.ListResult.InvokeRequired)
            {
                mainForm.ListResult.Invoke(new Action(UpdateQueueListBox));
            }
            else
            {
                ClearQueueListBox();
                foreach (string resultString in infoString)
                {
                    mainForm.UpdateQueue(resultString);
                }
            }
        }


        //Methods to clear the result list box and the queue list box

        public void ClearResultListBox()
        {
            mainForm.ListResult.Items.Clear();
        }

        public void ClearQueueListBox()
        {
            mainForm.ListOutput.Items.Clear();
        }
    }
}

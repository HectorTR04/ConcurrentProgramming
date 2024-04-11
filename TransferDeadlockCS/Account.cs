using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TransferDeadlock
{
    public class Account
    {
        int accountBalance;
        public Mutex transferMutex = new Mutex();

        //Method which provides a solution to the deadlock situation
        public void NoDeadlockTransfer(Mutex bigLock, Account reciever, int amount, string accountName, string recieverName)
        {      
            bigLock.WaitOne();
            Thread.Sleep(1000);
            reciever.transferMutex.WaitOne();
            reciever.accountBalance += amount;
            accountBalance -= amount;
            Console.WriteLine($"{accountName} is inside the transfer method");
            Console.WriteLine($"{amount} was transferred to {recieverName} from {accountName}. {accountName} " +
                $"current balance = {accountBalance}");
            bigLock.ReleaseMutex();
            reciever.transferMutex.ReleaseMutex();
        }

        //Method which simulates the deadlock situation
        public void DeadlockTransfer(Account receiver, int amount, string accountName, string receiverName)
        {
            lock (this)
            {
                Thread.Sleep(50); //Minor delay because the operation is short and threads sometimes still get through
                lock (receiver)
                {
                    receiver.accountBalance += amount;
                    accountBalance -= amount;
                    Console.WriteLine($"{accountName} is inside the transfer method");
                    Console.WriteLine($"{amount} was transferred to {receiverName} from {accountName}. {accountName} " +
                        $"current balance = {accountBalance}");
                }
            }
        }
    }
}

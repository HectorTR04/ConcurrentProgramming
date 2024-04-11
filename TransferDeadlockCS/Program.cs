namespace TransferDeadlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Choose to run either the method simulating deadlock or the solution
            Transaction transaction = new Transaction();
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.WriteLine("Are we failing to lock or locking for real?");
                string userInput = Console.ReadLine();

                switch (userInput.ToLower())
                {
                    case "failing to lock":
                        transaction.StartDeadlockTransaction();
                        isValidInput = true;
                        break;
                    case "locking for real":
                        transaction.StartNoDeadlockTransaction();
                        isValidInput = true;
                        break;
                    default:
                        Console.WriteLine("You had one job, enter one of the two phrases");
                        break;
                }
            }
        }
    }
}

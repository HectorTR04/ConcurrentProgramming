namespace LoanManagementSys.Tasks
{
    public class AdminTask : BaseTask
    {
        ProductManager productManager;
        public AdminTask(ProductManager productManager) 
        {
            this.productManager = productManager;
        }

        /// <summary>
        /// This method is run by the thread assigned to perform the task. It requests
        /// adding products to the list of products. 
        /// </summary>
        public void Run()
        {
            while (isRunning)
            {
                productManager.AddNewProduct();
                Thread.Sleep(random.Next(6000,16000));
            }
        }

    }
}

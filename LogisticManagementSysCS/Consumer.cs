using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LogisticManagementSystem
{
    /// <summary>
    /// Consumer class which handles removing items from the storage.
    /// </summary>
    public class Consumer
    {
        Product.CategoryType consumerType;
        Storage<Product> storage;
        LogisticManager logisticManager;
        public List<Product> loadedProducts = new List<Product>();
        bool isRunning = true;
        int capactity;
        public bool IsRunning {  get { return isRunning; } set { isRunning = value; } }
        public int Capacity { get { return capactity; } set { capactity = value; } }

        public Consumer(Product.CategoryType consumerType, Storage<Product> storage, int capacity, LogisticManager logisticManager)
        {
            this.consumerType = consumerType;
            this.storage = storage;
            this.capactity = capacity;
            this.logisticManager = logisticManager;
        }
        public void Run()
        {
            while (isRunning)
            {
                Consuming();  
                ResetCapacity();
                Thread.Sleep(1000);
            }
        }
        //Method to run the Consume method of the Storage class and add products to the Consumers list of products
        public void Consuming()
        {
            if (loadedProducts.Count < capactity )
            {
                Product product = storage.Consume();
                loadedProducts.Add(product);
            }
            else
            {
                switch (consumerType)
                {
                    case Product.CategoryType.Food:
                        logisticManager.mainForm.UpdateIcaStatus(false);
                        break;
                    case Product.CategoryType.Electronics:
                        logisticManager.mainForm.UpdateElgigantenStatus(false);
                        break;
                    case Product.CategoryType.Tools:
                        logisticManager.mainForm.UpdateClasOhlsonStatus(false);
                        break;
                }
            }
        }
        //Method to reset capacity of a consumer to let it start loading again
        public void ResetCapacity()
        {
            switch (consumerType)
            {
                case Product.CategoryType.Food:
                    if (logisticManager.mainForm.IcaCheckbox.Checked)
                    {
                        if (loadedProducts.Count >= capactity)
                        {
                            loadedProducts.Clear();
                        }
                        logisticManager.mainForm.UpdateIcaStatus(true);
                    }
                    break;
                case Product.CategoryType.Electronics:
                    if (logisticManager.mainForm.ElgigantenCheckbox.Checked)
                    {
                        if (loadedProducts.Count >= capactity)
                        {
                            loadedProducts.Clear();
                        }
                        logisticManager.mainForm.UpdateElgigantenStatus(true);
                    }
                    break;
                case Product.CategoryType.Tools:
                    if (logisticManager.mainForm.ClasOhlsonCheckbox.Checked)
                    {
                        if (loadedProducts.Count >= capactity)
                        {
                            loadedProducts.Clear();
                        }
                        logisticManager.mainForm.UpdateClasOhlsonStatus(true);
                    }
                    break;
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace LogisticManagementSystem
{
    /// <summary>
    /// Producer class which handles adding products from the create Products list to the Storage
    /// </summary>
    public class Producer
    {
        Product.CategoryType producerType;
        Storage<Product> storage;
        LogisticManager logisticManager;
        bool isRunning = true;
        public bool IsRunning { get { return isRunning; } set { isRunning = value; } }

        public Producer(Product.CategoryType producerType, Storage<Product> storage, LogisticManager logisticManager)
        {
            this.producerType = producerType;  
            this.storage = storage;
            this.logisticManager = logisticManager;
        }

        public void Run()
        {
            while (isRunning)
            {
                if (!isRunning)
                {
                    continue;
                }
                if (logisticManager.products.Count != 0)
                {
                    Product randomProduct = GetRandomProduct();
                    storage.Produce(randomProduct); //Runs the produce method of the Storage class to add products to the Storage
                    Thread.Sleep(1000);
                }
            }  
           
        }
        //Method to get a random product from the list of generated products
        public Product GetRandomProduct()
        {
            Random random = new Random();
            List<Product> matchingProducts = 
                logisticManager.products.Where(product => product.Type == this.producerType).ToList();          
            int index = random.Next(0, matchingProducts.Count);
            Product validProduct = matchingProducts[index];
            return validProduct;
        }

       
    }
}

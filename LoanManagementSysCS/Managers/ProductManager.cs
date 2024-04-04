using LoanManagementSys.Managers;
using LoanManagementSys.SystemItems;

namespace LoanManagementSys
{
    /// <summary>
    /// Manager which handles adding a list of inital test products to the system. 
    /// Includes methods for creating info strings that display the data of each product,
    /// removing products from the product list and allowing an admin to add new products  to the list while the program is running.
    /// </summary>
    public class ProductManager : BaseManager<Product>
    {

        private readonly string[] _testProducts; //String array to hold test product entries from a text file as strings
        private readonly string[] _newProducts; //String array to hold entries for products that can be added by an admin from a text file as strings
        List<Product> addedProducts = new List<Product>(); //A list which holds products specifically added by an admin to display notifications
        private Random random; //A system random used to generate a random product when an admin wants to add a product to the system

        public ProductManager()
        {
            var path = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\"));
            _testProducts = File.ReadAllLines
                (newPath + "\\Product.txt"); //Reads text file containing test product entries
            _newProducts = File.ReadAllLines
              (newPath + "\\NewProduct.txt"); //Reads text file containing entries for products that can be added by an admin
            random = new Random();
        }

        //Method which creates an array of strings to display information about the test products.       
        public string[] GetProductInfoStrings()
        {
            if (NoProductsAvailable())
            { //Return a single line indicating no products available
                return new string[] { "Products available: 0" };
            }
            //Create an array with enough space to accommodate the number of products available and the item strings
            string[] infoStrings = new string[_systemItems.Count + 1];

            infoStrings[0] = $"Number of products available: {_systemItems.Count}";

            //Fill the array with item strings displaying the product's data 
            for (int i = 0; i < _systemItems.Count; i++)
            {                
                infoStrings[i + 1] = _systemItems[i].ToString();
            }
            //Return the array of infoStrings
            return infoStrings;
        }

        //Method which creates an array of string to display a notification for when a new product is added to the product list
        public string[] GetAddedProductsInfoString()
        {
            string[] infoStrings = new string[addedProducts.Count];

            for (int i = 0; i < addedProducts.Count; i++)
            {
                infoStrings[i] = $"New product added: {addedProducts[i]}";
            }
            return infoStrings;
        }

        //Method used to remove a product from the product list
        public void Remove(Product product)
        {
            _systemItems.Remove(product);
        }

        //Method which adds the test products from the text file to the product list
        public void AddTestProducts()
        {
            foreach (string line in _testProducts)
            {
                //Split the line into two strings based on the comma separator
                string[] parts = line.Split(',');

                //Check if there are exactly two parts
                if (parts.Length == 2)
                {
                    string id = parts[0];  
                    string name = parts[1];
                    //Create a product using the id and name read from the text file
                    CreateProduct(id, name);
                }
                else
                {   //Check if the formatting for an entry in the text file is incorrect
                    Console.WriteLine("Invalid line format");
                }
            }            
        }   
        
        /// <summary>
        /// This method is used for randomly choosing a product from the file containing new product entires 
        /// that an admin can add to the product list. The method also adds the product to a temporary list which 
        /// is used to create notification info strings each time a new product is added to the system.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void AddNewProduct()
        {
            int randomIndex = random.Next(0, _newProducts.Length);

            // Get the random product name
            string randomProduct = _newProducts[randomIndex];

            string[] parts = randomProduct.Split(',');

            if (parts.Length == 2)
            {
                string id = parts[0];  
                string name = parts[1];
                var addedProduct = CreateProduct(id, name); //Add new product to products list
                addedProducts.Add(addedProduct); //Add product to temporary list holding only newly added products
            }
            else
            {   //Check if the formatting for an entry in the text file is incorrect
                Console.WriteLine("Invalid line format");
                throw new Exception();
            }
            
        }

        //Return true if the list of items is empty, and thus no product available for loaning.
        private bool NoProductsAvailable()
        {
            return (_systemItems == null || !_systemItems.Any());
        }

        // This method is called for creating products to be added tothe product list.       
        public Product CreateProduct(string id, string name)
        {
            Product product = new Product(); 
            product.ID = id;
            product.Name = name;
            _systemItems.Add(product);
            return product;           
        }
    }   
}

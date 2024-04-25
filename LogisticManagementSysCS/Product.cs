using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LogisticManagementSystem
{
    /// <summary>
    /// Class which represents a product in the logistics management system
    /// </summary>
    public class Product
    {
        string name;
        double price;
        public enum CategoryType { Food, Electronics, Tools}
        CategoryType type;

        public Product(string name, double price, CategoryType type)
        {
            this.name = name;
            this.price = price;
            this.type = type;
        }

        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }

        public CategoryType Type { get { return type; } set { type = value; } }
        public override string ToString()
        {
            return $"Name: {name}, Price: {price}";
        }
    }   
}

        

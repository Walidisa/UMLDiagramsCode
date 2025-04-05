using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagramsCode
{
    public class Product
    {
        private string productId;
        private string name;
        private string description;
        private double price;
        private int stockQuantity;
        private string category;

        public Product(string productId, string name, string description, double price,
                      int stockQuantity, string category)
        {
            this.productId = productId;
            this.name = name;
            this.description = description;
            this.price = price;
            this.stockQuantity = stockQuantity;
            this.category = category;
        }
        
        public void ApplyDiscount(double discount)
        {
            // Apply discount to the price
            price = price * (1 - discount);
        }

        public void UpdateStock(int quantityChange)
        {
            // Update stock quantity
            stockQuantity += quantityChange;
        }

        public bool IsInStock()
        {
            // Check if product is in stock
            if(stockQuantity > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public string ProductId { get => productId; set => productId = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public int StockQuantity { get => stockQuantity; set => stockQuantity = value; }
        public string Category { get => category; set => category = value; }
    }
}

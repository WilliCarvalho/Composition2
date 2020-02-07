using System;
using System.Collections.Generic;
using System.Text;
using Composition3.Entitites;

namespace Composition3.Entitites
{
    class OrderItem
    {
        public int Quantity { get; set;}
        public double Price { get; set;}
        public Product Product { get; set; }
        //public List<Product> Product { get; set; } = new List<Product>(); 
        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        //public void AddProduct(Product product)
        //{
        //    Product.Add(product);
        //}

        public double SubTotal()
        {
            return Price * Quantity;      
        }

        public override string ToString()
        {
            return Product.Name +
                   ", Quantity: " +
                   Quantity +
                   ", Subtotal: " +
                   SubTotal();
        }
    }
}

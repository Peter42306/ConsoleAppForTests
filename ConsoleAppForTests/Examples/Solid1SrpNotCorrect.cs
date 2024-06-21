using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class Solid1SrpNotCorrect
    {
        
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }

    public class Order
    {
        public int OrderNumber { get; private set; }
        public DateTime OrderDate { get; private set; }
        public List<Product> Products { get; private set; }

        public Order(int orderNumber)
        {
            OrderNumber = orderNumber;
            OrderDate = DateTime.Now; // Устанавливаем текущую дату
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public void SaveProduct(Product product)
        {
            Products.Contains(product);
        }
    }
}

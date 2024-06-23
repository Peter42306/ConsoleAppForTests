using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class SolidOcp
    {
        public static void Run()
        {
            Order order1 = new Order
            {
                Id = 15,
                CustomerName = "Test",
                TotalAmount = 1000,
                OrderDate = DateTime.Now
            };

            IOrderFormatter orderFormatter1 = new LongFormatter();
            PrintManager printManager = new PrintManager();
            printManager.Print(order1, orderFormatter1);

            IOrderFormatter orderFormatter2 = new ShortFormatter();
            printManager.Print(order1, orderFormatter2);

        }

        public class Order
        {
            public int Id { get; set; }
            public string CustomerName { get; set; }
            public decimal TotalAmount { get; set; }
            public DateTime OrderDate { get; set; }
        }

        public interface IOrderFormatter
        {
            string Format(Order order);
        }

        public class ShortFormatter : IOrderFormatter
        {
            public string Format(Order order)
            {
                return $"Order Id: {order.Id}, Total: {order.TotalAmount}";
            }
        }

        public class LongFormatter : IOrderFormatter
        {
            public string Format(Order order)
            {
                return $"Order Id: {order.Id}\n" +
                    $"Customer: {order.CustomerName}\n" +
                    $"Total amount:{order.TotalAmount}\n" +
                    $"Date:{order.OrderDate.ToShortDateString()}\n";
            }
        }

        public class PrintManager
        {
            public void Print(Order order, IOrderFormatter orderFormatter)
            {
                string formattedOrder = orderFormatter.Format(order);
                Console.WriteLine(formattedOrder);
            }
        }

    }
}

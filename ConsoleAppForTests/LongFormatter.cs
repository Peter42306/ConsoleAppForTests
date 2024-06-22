using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests
{
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
}

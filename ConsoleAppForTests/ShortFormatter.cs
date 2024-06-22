using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests
{
    public class ShortFormatter : IOrderFormatter
    {
        public string Format(Order order)
        {
            return $"Order Id: {order.Id}, Total: {order.TotalAmount}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests
{
    public class PrintManager
    {
        public void Print(Order order, IOrderFormatter orderFormatter) 
        {
            string formattedOrder=orderFormatter.Format(order);
            Console.WriteLine(formattedOrder);
        }
    }
}

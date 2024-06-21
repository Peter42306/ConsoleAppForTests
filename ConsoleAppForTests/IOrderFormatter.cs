using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests
{
    public interface IOrderFormatter
    {
        string Format(Order order);
    }
}

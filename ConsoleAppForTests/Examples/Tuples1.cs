using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class Tuples1
    {
        public static void Run()
        {
            // Creating a tuple
            var person = ("John", "Doe", 40);

            // Accessing tuple elements
            Console.WriteLine($"First Name: {person.Item1}");
            Console.WriteLine($"Last Name: {person.Item2}");
            Console.WriteLine($"Last Name: {person.Item3}");
        }
    }
}

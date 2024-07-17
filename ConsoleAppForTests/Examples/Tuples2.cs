using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class Tuples2
    {
        public static void Run()
        {
            // Creating an array of tuples
            var people = new[]
            {
            ("John", "Doe", 30),
            ("Jane", "Smith", 28),
            ("Sam", "Brown", 25)
            };

            // Filtering and selecting people based on age
            var selectPeopleByAge = people
                .Where(person => person.Item3 > 24)
                .Select(person => (person.Item1, person.Item2));

            foreach (var person in selectPeopleByAge)
            {
                Console.WriteLine($"First Name: {person.Item1}, Last Name: {person.Item2}");
            }

            // Filtering people by name "John"
            var selectPeopleByName = people.
                Where(person => person.Item1=="John").
                Select(person=>(person.Item1,person.Item2,person.Item3));

            foreach (var item in selectPeopleByName)
            {                
                Console.WriteLine($"First Name: {item.Item1}, Last Name: {item.Item2}, Age: {item.Item3}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class Tuples3
    {
        public static void Run()
        {
            var person = new Person("John", "Deer", 25);
            var job = new Job("SmallCompany", "developer");

            var combinedInfo = (person._firstName, person._lastName, person._age, job._company, job._position);

            Console.WriteLine($"First Name: {combinedInfo._firstName}");
            Console.WriteLine($"Last Name: {combinedInfo._lastName}");
            Console.WriteLine($"Age: {combinedInfo._age}");
            Console.WriteLine($"Company: {combinedInfo._company}");
            Console.WriteLine($"Position: {combinedInfo._position}");
        }

        internal class Person
        {
            public string _firstName { get; set; }
            public string _lastName { get; set; }
            public int _age { get; set; }

            public Person(string firstName, string lastName, int age)
            {
                _firstName = firstName;
                _lastName = lastName;
                _age = age;
            }
        }

        internal class Job
        {
            public string _company { get; set; }
            public string _position { get; set; }

            public Job(string company, string position)
            {
                _company = company;
                _position = position;
            }
        }
    }
}

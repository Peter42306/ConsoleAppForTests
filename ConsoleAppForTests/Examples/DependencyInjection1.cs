using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class DependencyInjection1
    {
        public class Student
        {
            public string FirstName { get; private set; }
            public string LastName { get; private set; }
            private readonly IPrinter _printer;

            public Student(string firstName, string lastName, IPrinter printer)
            {
                FirstName = firstName;
                LastName = lastName;
                _printer = printer;
            }

            public void Print()
            {
                _printer.PrintStudent(this);
            }
        }

        public interface IPrinter
        {
            void PrintStudent(Student student);
        }

        public class ConsolePrint : IPrinter
        {
            public void PrintStudent(Student student)
            {
                Console.WriteLine($"Student: {student.FirstName} {student.LastName}");
            }
        }

        public static void Run()
        {
            IPrinter consolePrinter = new ConsolePrint();
            Student student = new Student("Ivan", "Ivanov", consolePrinter);
            student.Print();
        }
    }
}

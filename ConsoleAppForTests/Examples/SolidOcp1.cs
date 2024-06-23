using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleAppForTests.Examples.SolidOcp;

namespace ConsoleAppForTests.Examples
{
    internal class SolidOcp1
    {
        public static void Run()
        {
            Human human1 = new Human();

            ILog logger = new ConsoleLog();

            human1.SetLogger(logger);

            human1.AddPerson("Human 1 Person 1");
            human1.AddPerson("Human 1 Person 2");
            human1.AddPerson("Human 1 Person 3");
            human1.AddPerson("Human 1 Person 4");
            human1.AddPerson("Human 1 Person 5");

            List<string> listPeople1 = human1.GetPeople();

            foreach (string person in listPeople1)
            {
                Console.WriteLine($"FOREACH : Person: {person}");
            }

            for (int i = 0; i < human1.GetPeople().Count; i++)
            {
                string person = human1.GetPeople()[i];
                Console.WriteLine($"FOR : Person at index {i}: {human1}");
            }
        }

        

        internal class Human
        {
            private List<string> _people;  // Список людей
            private ILog _logger;          // Интерфейс для логирования

            public Human()
            {
                _people = new List<string>();
            }

            public void SetLogger(ILog logger)
            {
                _logger = logger;
                _logger.Log("Logger has been set");
            }

            public void AddPerson(string name)
            {
                _people.Add(name);
                _logger.Log($"person {name} has been successfully added");
            }

            public List<string> GetPeople()
            {
                return _people;
            }
        }
               

        internal interface ILog
        {
            void Log(string message);
        }

        // Класс для реализации интерфейса логирования
        public class ConsoleLog : ILog
        {
            public void Log(string message)
            {
                Console.WriteLine($"[LOG]: {message}");
            }
        }
    }
}

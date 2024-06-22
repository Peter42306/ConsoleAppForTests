using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests
{
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
            _logger.Log($"person {name} has been seccessfully added");
        }

        public List<string> GetPeople()
        {
            return _people;
        }
    }
}

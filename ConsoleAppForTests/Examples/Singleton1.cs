using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class Singleton1
    {
        public class Logger
        {
            // Поле для хранения единственного экземпляра класса
            private static Logger _instance;

            // Объект для обеспечения потокобезопасности
            private static readonly object _lock = new object();

            // Приватный конструктор для предотвращения создания экземпляров класса извне
            private Logger()
            {
                // Открытие файла для записи логов
                LogFilePath = "log.txt";
            }

            // Метод для получения единственного экземпляра класса
            public static Logger Instance
            {
                get
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Logger();
                        }
                        return _instance;
                    }
                }
            }

            // Путь к файлу логов
            public string LogFilePath { get; private set; }

            // Метод для записи логов
            public void Log(string message)
            {
                lock (_lock)
                {
                    using (StreamWriter writer = new StreamWriter(LogFilePath, true))
                    {
                        writer.WriteLine($"{DateTime.Now}: {message}");
                    }
                }
            }
        }

        public static void Run()
        {
            // Получение экземпляра класса Logger
            Logger logger = Logger.Instance;

            // Запись сообщений в лог
            logger.Log("This is the first log message");
            logger.Log("This is the second log message");

            // Проверка, что второй вызов возвращает тот же экземпляр
            Logger anotherLogger = Logger.Instance;
            Console.WriteLine(Object.ReferenceEquals(logger,anotherLogger));
        }

    }
}

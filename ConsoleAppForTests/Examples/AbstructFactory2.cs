using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class AbstructFactory2
    {
        // интерфейсы для компонентов машин
        public interface IEngine
        {
            void EngineAssembled();
            string GetType();
        }
        public interface IBody
        {
            void BodyAssembled();
            string GetType();
        }

        // конкретные реализации компонентов машин
        public class ElectricEngine : IEngine
        {
            public void EngineAssembled()
            {
                Console.WriteLine("Electric engine assembled");
            }

            string IEngine.GetType()
            {
                string type = "Electric engine";
                return type;
            }
        }
        public class ElectricBody : IBody
        {
            public void BodyAssembled()
            {
                Console.WriteLine("Electric body assembled");
            }

            string IBody.GetType()
            {
                string type = "Electric body";
                return type;
            }
        }
        public class DieselEngine : IEngine
        {
            public void EngineAssembled()
            {
                Console.WriteLine("Diesel engine assembled");
            }

            string IEngine.GetType()
            {
                string type = "Diesel body";
                return type;
            }
        }
        public class DieselBody : IBody
        {
            public void BodyAssembled()
            {
                Console.WriteLine("Diesel body assembled");
            }

            string IBody.GetType()
            {
                string type = "Diesel body";
                return type;
            }
        }

        // абстрактный интерфейс для фабрики машин
        public interface ICarFactory
        {
            IEngine CreateEngine();
            IBody CreateBody();
        }

        //  конкретные фабрики
        public class ElectricCarFactory : ICarFactory
        {
            IBody ICarFactory.CreateBody()
            {
                return new ElectricBody();
            }

            IEngine ICarFactory.CreateEngine()
            {
                return new ElectricEngine();
            }
        }
        public class DieselCarFactory : ICarFactory
        {
            IBody ICarFactory.CreateBody()
            {
                return new DieselBody();
            }

            IEngine ICarFactory.CreateEngine()
            {
                return new DieselEngine();
            }
        }

        public class Car
        {
            private readonly IEngine _engine;
            private readonly IBody _body;

            public Car(ICarFactory carFactory)
            {
                _engine = carFactory.CreateEngine();
                _body = carFactory.CreateBody();
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Car with {_engine.GetType()} and {_body.GetType()}.");
                _engine.EngineAssembled();
                _body.BodyAssembled();
            }
        }

        public static void Run()
        {
            ICarFactory carFactory = new ElectricCarFactory();
            Car car = new Car(carFactory);
            car.DisplayInfo();

            carFactory = new DieselCarFactory();
            car = new Car(carFactory);
            car.DisplayInfo();

            // Car with Electric engine and Electric body.
            // Electric engine assembled
            // Electric body assembled
            // Car with Diesel body and Diesel body.
            // Diesel engine assembled
            // Diesel body assembled
        }
    }
}

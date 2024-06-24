using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class DependencyInjection2
    {
        public interface IEngine
        {
            void Start();
        }

        public interface IBattery
        {
            void Charge();
        }

        public class ElectricEngine : IEngine
        {
            public void Start()
            {
                Console.WriteLine("Electric engine started.");
            }
        }

        public class CarBattery : IBattery
        {
            public void Charge()
            {
                Console.WriteLine("Car battery charging.");
            }
        }

        public class Car
        {
            private readonly IEngine _engine;
            private readonly IBattery _battery;

            public Car(IEngine engine, IBattery battery)
            {
                _engine = engine;
                _battery = battery;
            }

            public void Start()
            {
                _engine.Start();
                _battery.Charge();
                Console.WriteLine("Car started.");
            }
        }

        public static void Run()
        {
            IEngine engine = new ElectricEngine();
            IBattery battery = new CarBattery();
            Car car = new Car(engine, battery);
            car.Start();
        }

        // Electric engine started.
        // Car battery charging.
        // Car started.
    }
}

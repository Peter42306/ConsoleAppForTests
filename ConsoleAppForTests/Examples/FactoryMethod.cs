using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    public class FactoryMethod
    {
        public static void Run()
        {
            //ITransportFactory truckFactory=new TruckFactory();
            //ITransport truck=truckFactory.CreateTransport();
            //truck.Delivery();

            //ITransportFactory shipFactory=new ShipFactory();
            //ITransport ship=shipFactory.CreateTransport();
            //ship.Delivery();

            //ITransportFactory airplaneFactory=new AirplaneFactory();
            //ITransport airplane=airplaneFactory.CreateTransport();
            //airplane.Delivery();

            /////////////////////////////////////////////////////////////

            ITransportFactory transportFactory = new TruckFactory();
            ITransport transport = transportFactory.CreateTransport();
            transport.Delivery();

            transportFactory = new ShipFactory();            
            transport= transportFactory.CreateTransport();
            transport.Delivery();

            transportFactory = new AirplaneFactory();
            transport= transportFactory.CreateTransport();
            transport.Delivery();


        }

        public interface ITransport
        {
            void Delivery();
        }

        public class Truck : ITransport
        {
            public void Delivery()
            {
                Console.WriteLine("Delivery by Truck");
            }
        }

        public class Ship : ITransport
        {
            public void Delivery()
            {
                Console.WriteLine("Delivery by Ship");
            }
        }

        public class Airplane : ITransport
        {
            public void Delivery()
            {
                Console.WriteLine("Delivery by Airplane");
            }
        }

        public interface ITransportFactory
        {
            ITransport CreateTransport();
        }

        public class TruckFactory : ITransportFactory
        {
            public ITransport CreateTransport()
            {
                return new Truck();
            }
        }

        public class ShipFactory : ITransportFactory
        {
            public ITransport CreateTransport()
            {
                return new Ship();
            }
        }

        public class AirplaneFactory : ITransportFactory
        {
            public ITransport CreateTransport()
            {
                return new Airplane();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class AbstructFactory3
    {
        /*
         * Создайте систему для производства электроники, где у вас есть различные типы устройств 
         * (например, ноутбуки и смартфоны), каждый из которых имеет разные компоненты (например, процессор и батарею).
         */

        // интерфейсы
        public interface ICpu
        {
            void CpuDetails();
            string GetCpuDetails();
        }

        public interface IBattery
        {
            void BatteryDetails();
            string GetBatteryDetails();
        }

        // конкретные реализации компонентов
        public class LaptopCpu : ICpu
        {
            public void CpuDetails()
            {
                Console.WriteLine("Cpu of Laptop");
            }

            public string GetCpuDetails()
            {
                string type = "Cpu of Smartphone details";
                return type;               
            }
        }
        public class LaptopBattery : IBattery
        {
            public void BatteryDetails()
            {
                Console.WriteLine("Battery of Laptop");
            }

            public string GetBatteryDetails()
            {
                string type = "Battery of Laptop details";
                return type;
            }
        }
        public class SmartPhoneCpu : ICpu
        {
            public void CpuDetails()
            {
                Console.WriteLine("Cpu of Smartphone");
            }

            public string GetCpuDetails()
            {
                string type = "Cpu of Smartphone details";
                return type;
            }
        }
        public class SmartPhoneBattery : IBattery
        {
            public void BatteryDetails()
            {
                Console.WriteLine("Battery of Smartphone");
            }

            public string GetBatteryDetails()
            {
                string type = "Battery of Smartphone details";
                return type;
            }
        }

        // интерфейс для фабрики объектов
        public interface IDeviceFactory
        {
            ICpu CreateCpu();
            IBattery CreateBattery();
        }

        public class LaptopFactory : IDeviceFactory
        {
            IBattery IDeviceFactory.CreateBattery()
            {
                return new LaptopBattery();
            }

            ICpu IDeviceFactory.CreateCpu()
            {
                return new LaptopCpu();
            }
        }
        public class SmartPhoneFactory : IDeviceFactory
        {
            IBattery IDeviceFactory.CreateBattery()
            {
                return new SmartPhoneBattery();
            }

            ICpu IDeviceFactory.CreateCpu()
            {
                return new SmartPhoneCpu();
            }
        }

        // клиент
        public class Device
        {
            private readonly ICpu _cpu;
            private readonly IBattery _battery;

            public Device(ICpu cpu,IBattery battery)
            {
                _cpu = cpu;
                _battery = battery;
            }

            public void ShowDetails()
            {
                Console.WriteLine("Device details:");
                
                _cpu.CpuDetails();
                _cpu.GetCpuDetails();                

                _battery.BatteryDetails();
                _battery.GetBatteryDetails();                
            }
        }

        public static void Run()
        {
            IDeviceFactory deviceFactory=new LaptopFactory();
            var deviceCpu=deviceFactory.CreateCpu();
            var deviceBattery=deviceFactory.CreateBattery();

            Device device = new Device(deviceFactory.CreateCpu(), deviceFactory.CreateBattery());

            device.ShowDetails();
            Console.WriteLine();

            deviceCpu.CpuDetails();
            deviceCpu.GetCpuDetails();
            Console.WriteLine();

            deviceBattery.BatteryDetails();
            deviceBattery.GetBatteryDetails().ToString();
        }
    }
}

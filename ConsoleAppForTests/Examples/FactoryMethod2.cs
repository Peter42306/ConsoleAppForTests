using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class FactoryMethod2
    {
        // Задача: Создание системы оплаты 
        // Разработайте систему оплаты, используя паттерн "Фабричный метод". В системе должны быть различные способы оплаты, такие как:
        // - CreditCard
        // - PayPal
        // - BankTransfer

        public interface IPaySystem
        {
            void PaySystem();
        }

        public class CreditCard : IPaySystem
        {
            public void PaySystem()
            {
                Console.WriteLine("PaySystem CreditCard");
            }
        }

        public class PayPal : IPaySystem
        {
            public void PaySystem()
            {
                Console.WriteLine("PaySystem PayPal");
            }
        }

        public class BankTransfer : IPaySystem
        {
            public void PaySystem()
            {
                Console.WriteLine("PaySystem BankTransfer");
            }
        }

        public interface IPaySystemFactory
        {
            IPaySystem CreatePaySystem();
        }

        public class CreditCardFactory : IPaySystemFactory
        {
            IPaySystem IPaySystemFactory.CreatePaySystem()
            {
                return new CreditCard();
            }
        }

        public class PayPalFactory : IPaySystemFactory
        {
            IPaySystem IPaySystemFactory.CreatePaySystem()
            {
                return new PayPal();
            }
        }

        public class BankTransferFactory : IPaySystemFactory
        {
            IPaySystem IPaySystemFactory.CreatePaySystem()
            {
                return new BankTransfer();
            }
        }

        public static void Run()
        {
            IPaySystemFactory factory = new CreditCardFactory();
            IPaySystem paySystem = factory.CreatePaySystem();
            paySystem.PaySystem();

            factory=new PayPalFactory();
            paySystem = factory.CreatePaySystem();
            paySystem.PaySystem();

            factory=new BankTransferFactory();
            paySystem = factory.CreatePaySystem();
            paySystem.PaySystem();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class FactoryMethod3
    {
        /*
         * Задача: Система уведомлений
         * Разработайте систему уведомлений, используя паттерн "Фабричный метод". В системе должны быть различные способы отправки уведомлений, такие как:
         * EmailNotification
         * SMSNotification
         * PushNotification
         */

        public interface INotification
        {
            void NotificationMethod();
        }
        public class EmailNotification : INotification
        {
            public void NotificationMethod()
            {
                Console.WriteLine("Notification by Email");
            }
        }
        public class SmsNotification : INotification
        {
            public void NotificationMethod()
            {
                Console.WriteLine("Notification by SMS");
            }
        }
        public class PushNotification : INotification
        {
            public void NotificationMethod()
            {
                Console.WriteLine("Notification by Push");
            }
        }
        public class VoiceCallNotification : INotification
        {
            public void NotificationMethod()
            {
                Console.WriteLine("Notification by Voice Call");
            }
        }

        public interface INotificationFactory
        {
            INotification CreateNotification();
        }
        public class EmailNotificationFactory : INotificationFactory
        {
            INotification INotificationFactory.CreateNotification()
            {
                return new EmailNotification();
            }
        }
        public class SmsNotificationFactory : INotificationFactory
        {
            INotification INotificationFactory.CreateNotification()
            {
                return new SmsNotification();
            }
        }
        public class PushNotificationFactory : INotificationFactory
        {
            INotification INotificationFactory.CreateNotification()
            {
                return new PushNotification();
            }
        }
        public class VoiceCallFactory : INotificationFactory
        {
            INotification INotificationFactory.CreateNotification()
            {
                return new VoiceCallNotification();
            }
        }

        public static void Run()
        {
            INotificationFactory notificationFactory = new EmailNotificationFactory();
            INotification notification = notificationFactory.CreateNotification();
            notification.NotificationMethod();

            notificationFactory = new SmsNotificationFactory();
            notification = notificationFactory.CreateNotification();
            notification.NotificationMethod();

            notificationFactory = new PushNotificationFactory();
            notification = notificationFactory.CreateNotification();
            notification.NotificationMethod();

            INotificationFactory voiceCallNotificationFactory=new VoiceCallFactory();
            INotification voiceNotification=voiceCallNotificationFactory.CreateNotification();
            voiceNotification.NotificationMethod();
        }
    }
}

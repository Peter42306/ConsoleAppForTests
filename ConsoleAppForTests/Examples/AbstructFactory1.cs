using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class AbstructFactory1
    {
        /*
         * Есть различные типы продуктов: Button и Checkbox. 
         * И у нас есть два семейства продуктов: для Windows и для Mac. 
         * Мы хотим создать абстрактную фабрику, которая будет создавать эти продукты в зависимости от платформы
         */

        // Шаг 1: Интерфейсы для продуктов
        public interface IButton
        {
            void Render();
        }

        public interface ICheckBox
        {
            void Render();
        }

        // Шаг 2: Конкретные реализации продуктов для Windows
        public class WindowsButton : IButton
        {
            public void Render()
            {
                Console.WriteLine("Render a button in Windows style.");
            }
        }

        public class WindowsCheckbox : ICheckBox
        {
            public void Render()
            {
                Console.WriteLine("Render a checkbox in Windows style.");
            }
        }

        // Шаг 3: Конкретные реализации продуктов для Mac
        public class MacButton : IButton
        {
            public void Render()
            {
                Console.WriteLine("Render a button in Mac style.");
            }
        }

        public class MacCheckbox : ICheckBox
        {
            public void Render()
            {
                Console.WriteLine("Render a checkbox in Mac style.");
            }
        }

        // Шаг 4: Интерфейс абстрактной фабрики
        public interface IGUIFactory
        {
            IButton CreateButton();
            ICheckBox CreateCheckbox();
        }

        // Шаг 5: Конкретные фабрики для Windows
        public class WindowsFactory : IGUIFactory
        {
            public IButton CreateButton()
            {
                return new WindowsButton();
            }

            public ICheckBox CreateCheckbox()
            {
                return new WindowsCheckbox();
            }
        }

        // Шаг 6: Конкретные фабрики для Mac
        public class MacFactory : IGUIFactory
        {
            public IButton CreateButton()
            {
                return new MacButton();
            }

            public ICheckBox CreateCheckbox()
            {
                return new MacCheckbox();
            }
        }

        // Шаг 7: Клиентский код
        public class Application
        {
            private readonly IButton _button;
            private readonly ICheckBox _checkbox;

            public Application(IGUIFactory factory)
            {
                _button = factory.CreateButton();
                _checkbox = factory.CreateCheckbox();
            }

            public void Render()
            {
                _button.Render();
                _checkbox.Render();
            }
        }

        public static void Run()
        {
            IGUIFactory factory;

            // Выбор фабрики в зависимости от платформы
            string platform = "Windows";

            if (platform == "Windows")
            {
                factory = new WindowsFactory();
            }
            else
            {
                factory = new MacFactory();
            }

            Application application = new Application(factory);
            application.Render();
        }

        //Render a button in Windows style.
        //Render a checkbox in Windows style.
    } 
}

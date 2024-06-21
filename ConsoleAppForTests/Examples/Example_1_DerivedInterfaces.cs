using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    public class Example_1_DerivedInterfaces
    {
        public static void Run()
        {
            IBase baseObject = new Implementation();
            baseObject.BaseMethod();            
            Console.WriteLine();

            IDerived derived=new Implementation();
            derived.BaseMethod();
            derived.DerivedMethod();
            Console.WriteLine();

            ICombined combined=new CombinedImplementation();
            combined.FirstMethod();
            combined.SecondMethod();
            combined.CombinedMethod();
            Console.WriteLine();

        }

        //Пример 1: Простое наследование интерфейсов

        // Базовый интерфейс
        public interface IBase
        {
            void BaseMethod();
        }

        // Наследуемый интерфейс
        public interface IDerived : IBase
        {
            void DerivedMethod();
        }

        // Класс, реализующий наследуемый интерфейс
        public class Implementation : IDerived
        {
            public void BaseMethod()
            {
                Console.WriteLine("BaseMethod implementation.");
            }

            public void DerivedMethod()
            {
                Console.WriteLine("DerivedMethod implementation.");
            }
        }

        // Пример 2: Наследование нескольких интерфейсов

        public interface IFirst
        {
            void FirstMethod();
        }

        public interface ISecond
        {
            void SecondMethod();
        }

        public interface ICombined : IFirst, ISecond
        {
            void CombinedMethod();
        }

        public class CombinedImplementation : ICombined
        {
            public void FirstMethod()
            {
                Console.WriteLine("FirstMethod implementation.");
            }

            public void SecondMethod()
            {
                Console.WriteLine("SecondMethod implementation.");
            }

            public void CombinedMethod()
            {
                Console.WriteLine("CombinedMethod implementation.");
            }
        }
    }
}

//BaseMethod implementation.

//BaseMethod implementation.
//DerivedMethod implementation.

//FirstMethod implementation.
//SecondMethod implementation.
//CombinedMethod implementation.

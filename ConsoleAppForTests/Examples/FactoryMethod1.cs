using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class FactoryMethod1
    {
        public static void Run()
        {
            // создание фабрик для пингвинов и попугаев
            IAnimalFactory penguinFactory = new PenguinFactory();
            IAnimalFactory parrotFactory = new ParrotFactory();

            // создание животных
            IAnimal penguin = penguinFactory.CreateAnimal();
            IAnimal parrot = parrotFactory.CreateAnimal();

            penguin.Eat();
            penguin.Move();
            if (penguin is ISwim checkIfSwim)
            {
                checkIfSwim.Swim();
            }

            parrot.Eat();
            parrot.Move();
            if (parrot is IFly checkIfFly)
            {
                checkIfFly.Fly();
            }
        }


        public interface IAnimal
        {
            void Eat();
            void Move();
        }

        public interface IFly
        {
            void Fly();
        }

        public interface ISwim
        {
            void Swim();
        }

        class Pengiun : IAnimal, ISwim
        {
            public void Eat() => Console.WriteLine("Penguin eat fish");
            public void Move() => Console.WriteLine("Penguin moving");
            public void Swim() => Console.WriteLine("Penguin swim");
        }

        class Parrot : IAnimal, IFly
        {
            public void Eat() => Console.WriteLine("Parrot eat nuts");
            public void Move() => Console.WriteLine("Parrot run on ground");
            public void Fly() => Console.WriteLine("Parrot fly");
        }

        // Интерфейс для фабрики животных
        public interface IAnimalFactory
        {
            IAnimal CreateAnimal();
            IFly CreateFly();
            ISwim CreateSwim();
        }

        // Фабрика для создания Пингвинов
        public class PenguinFactory : IAnimalFactory
        {
            public IAnimal CreateAnimal()
            {
                return new Pengiun();
            }

            public ISwim CreateSwim()
            {
                return new Pengiun();
            }
            public IFly CreateFly()
            {
                return null;
            }
        }

        // Фабрика для создания Попугаев
        public class ParrotFactory : IAnimalFactory
        {
            public IAnimal CreateAnimal()
            {
                return new Parrot();
            }

            public IFly CreateFly()
            {
                return new Parrot();
            }

            public ISwim CreateSwim()
            {
                return null;
            }
        }

    }
}

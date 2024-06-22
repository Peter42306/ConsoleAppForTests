using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class FactoryMethod1WithEnum
    {
        public static void Run()
        {
            // создание фабрик для пингвинов и попугаев
            IAnimalFactory animalFactory = new AnimalFactory();

            // Создание животных с использованием фабрики и перечислений
            IAnimal penguin = animalFactory.CreateAnimal(AnimalType.Penguin);
            IAnimal parrot = animalFactory.CreateAnimal(AnimalType.Parrot);

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

        // ABSTRUCT FACTORY WITH ENUM

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

        public enum AnimalType
        {
            Penguin,
            Parrot
        }

        // Интерфейс для фабрики животных
        public interface IAnimalFactory
        {
            IAnimal CreateAnimal(AnimalType animalType);
        }

        public class AnimalFactory : IAnimalFactory
        {
            public IAnimal CreateAnimal(AnimalType animalType)
            {
                switch (animalType)
                {
                    case AnimalType.Penguin:
                        return new Pengiun();
                    case AnimalType.Parrot:
                        return new Parrot();
                    default:
                        throw new ArgumentException("Invalid animal type");
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class DependecyInjection
    {
        public static void Run()
        {
            Console.WriteLine($"Executing: {MethodBase.GetCurrentMethod().DeclaringType.Name}");

            IAnimal penguin=new Penguin();
            ISwim swim=penguin as ISwim;

            IAnimal parrot=new Parrot();
            IFly fly=parrot as IFly;

            AnimalService animalServicePenguin = new AnimalService(penguin, null, swim);
            AnimalService animalServiceParrot = new AnimalService(parrot, fly, null);

            animalServicePenguin.InteractWithAnimal();
            animalServiceParrot.InteractWithAnimal();
        }

        // DEPENDENCY INJECTION
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

        public class Penguin : IAnimal, ISwim
        {
            public void Eat() => Console.WriteLine("Penguin eat fish");
            public void Move() => Console.WriteLine("Penguin moving");
            public void Swim() => Console.WriteLine("Penguin swim");
        }

        public class Parrot : IAnimal, IFly
        {
            public void Eat() => Console.WriteLine("Parrot eat nuts");
            public void Move() => Console.WriteLine("Parrot run on ground");
            public void Fly() => Console.WriteLine("Parrot fly");
        }

        // Класс для внедрения зависимостей (Dependency Injection)
        public class AnimalService
        {
            private readonly IAnimal _animal;
            private readonly IFly _animalFly;
            private readonly ISwim _animalSwim;

            // Конструктор для внедрения зависимостей
            public AnimalService(IAnimal animal, IFly animalFly, ISwim animalSwim)
            {
                _animal = animal;
                _animalFly = animalFly;
                _animalSwim = animalSwim;
            }

            // Методы для работы с животными
            public void InteractWithAnimal()
            {
                _animal.Eat();
                _animal.Move();
                _animalFly?.Fly();
                _animalSwim?.Swim();
            }
        }

    }
}

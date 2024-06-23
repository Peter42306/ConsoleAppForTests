using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    public class Builder1
    {
        // Шаг 1: Определите продукт (House)
        public class House
        {
            public string Walls { get; set; }
            public string Doors { get; set; }
            public string Windows { get; set; }

            public void Details()
            {
                Console.WriteLine($"House with {Walls} walls, {Doors} doors, {Windows} windows");
            }
        }

        // Шаг 2: Определите интерфейс строителя(IHouseBuilder)
        public interface IHouseBuilder
        {
            void BuildWalls();
            void BuildDoors();
            void BuildWindows();
            House GetHouse();
        }

        // Шаг 3: Реализуйте конкретные строители(Concrete Builders)
        public class ConcreteHouseBuilder : IHouseBuilder
        {
            private House _house = new House();

            public void BuildDoors()
            {
                _house.Doors = "plastic";
            }

            public void BuildWalls()
            {
                _house.Walls = "concrete";
            }

            public void BuildWindows()
            {
                _house.Windows = "plastic";
            }

            public House GetHouse()
            {
                return _house;
            }
        }
        public class WoodenHouseBuilder : IHouseBuilder
        {
            private House _house = new House();

            public void BuildDoors()
            {
                _house.Doors = "wooden";
            }

            public void BuildWalls()
            {
                _house.Walls = "wooden";
            }

            public void BuildWindows()
            {
                _house.Windows = "wooden";
            }

            public House GetHouse()
            {
                return _house;
            }
        }

        // Шаг 4: Определите директора (Director)
        public class HouseDirector
        {
            private readonly IHouseBuilder _houseBuilder;

            public HouseDirector(IHouseBuilder houseBuilder)
            {
                _houseBuilder = houseBuilder;
            }

            public void ConstructHouse()
            {
                _houseBuilder.BuildWalls();
                _houseBuilder.BuildWindows();
                _houseBuilder.BuildDoors();
            }

            public House GetHouse()
            {
                return _houseBuilder.GetHouse();
            }
        }

        public static void Run()
        {
            IHouseBuilder concreteHouseBuilder= new ConcreteHouseBuilder();
            IHouseBuilder woodenHouseBuilder=new WoodenHouseBuilder();

            HouseDirector houseDirector=new HouseDirector(concreteHouseBuilder);
            houseDirector.ConstructHouse();
            House concreteHouse=houseDirector.GetHouse();
            concreteHouse.Details();

            houseDirector=new HouseDirector(woodenHouseBuilder);
            houseDirector.ConstructHouse();
            House woodenHouse=houseDirector.GetHouse();
            woodenHouse.Details();
        }
    }
}

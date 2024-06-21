using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    public abstract class FigureAbstract
    {
        private int _x;
        private int _y;

        public FigureAbstract(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int GetX { get { return _x; } }
        public int GetY { get { return _y; } }

        // Абстрактный метод Draw, который должен быть реализован в производных классах
        public abstract void Draw();

        // для вызова из Main
        public static void Run()
        {
            Circle circle1 = new Circle(10, 20, 50);
            Circle circle2 = new Circle(100, 200, 500);

            Rectangle rectangle1 = new Rectangle(50, 51, 100, 200);
            Rectangle rectangle2 = new Rectangle(500, 510, 1000, 2000);

            circle1.Draw(); circle2.Draw();
            Console.WriteLine();
            rectangle1.Draw(); rectangle2.Draw();
            Console.WriteLine();
        }
    }

    public class Circle : FigureAbstract
    {
        private int _radius;

        public Circle(int x, int y, int radius) : base(x, y)
        {
            _radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a Circle at coordinates ({GetX}, {GetY}) with radius {_radius}");
        }
    }

    public class Rectangle : FigureAbstract
    {
        private int _a;
        private int _b;

        public Rectangle(int x, int y, int a, int b) : base(x, y)
        {
            _a = a;
            _b = b;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a Rectangle at coordinates ({GetX}, {GetY}) with side A {_a} and side B {_b}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests
{
    public class Circle : IFigure
    {
        private int _x;     // Координата X центра круга
        private int _y;     // Координата Y центра круга
        private int _radius;// Радиус круга

        public Circle(int x,int y,int radius)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public int x { get ; set; }
        public int y { get ; set ; }

        public void Draw()
        {
            Console.WriteLine($"Drawing a circle at coordinates ({_x}, {_y}) with radius {_radius}");
        }
    }
}

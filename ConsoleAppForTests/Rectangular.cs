using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests
{
    public class Rectangular : IFigure
    {
        private int _x;
        private int _y;
        private int _width;
        private int _height;

        public Rectangular(int x,int y,int width, int height)
        {
            _x = x; 
            _y = y; 
            _width = width; 
            _height = height;
        }

        public int x { get ; set ; }
        public int y { get; set; }

        public void Draw()
        {
            Console.WriteLine($"Drawing rectangular at coordinates ({_x}, {_y}) with width {_width} and with hight {_height}");
        }
    }
}

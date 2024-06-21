//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppForTests.Examples
//{
//    public interface IFigureInterface
//    {
//        int x { get; set; }
//        int y { get; set; }

//        void Draw();
//    }

//    public class Circle : IFigureInterface
//    {
//        public int x { get; set; }
//        public int y { get; set; }
//        private int _radius;

//        public Circle(int x,int y,int radius)
//        {
//            this.x = x;
//            this.y = y;
//            _radius = radius;
//        }

        

//        public void Draw()
//        {
//            Console.WriteLine($"Drawing Circle at coordinates ({_x}, {_y}) with radius {_radius}");
//        }

//        //private int _x;
//        //private int _y;
//        //private int _radius;

//        //public Circle(int x, int y, int radius)
//        //{
//        //    _x = x;
//        //    _y = y;
//        //    _radius = radius;
//        //}

//        //public int x { get { return _x; } set { _x = value; } }
//        //public int y { get { return _y; } set { _y = value; } }


//        //public void Draw()
//        //{
//        //    Console.WriteLine($"Drawing Circle at coordinates ({_x}, {_y}) with radius {_radius}");
//        //}



//        //public static void Run()
//        //{
//        //    Circle circle1 = new Circle(1, 2, 10);
//        //    Circle circle2 = new Circle(10, 20, 100);

//        //    circle1.Draw();
//        //    circle2.Draw();
//        //}

//    }

//    //public class Circle() : IFigureInterface
//    //{
//    //    int IFigureInterface.GetX { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//    //    int IFigureInterface.GetY { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//    //}
//}

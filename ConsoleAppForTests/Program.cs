using ConsoleAppForTests.Examples;

namespace ConsoleAppForTests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //IFigureInterface.Run();
            //Example_5_GetMd5Hash.Run();
            Circle circle1 = new Circle(1, 10, 1000);
            circle1.Draw();

            Rectangular rectangular1 = new Rectangular(10, 15, 1000, 500);
            rectangular1.Draw();

            IFigure circle2 = new Circle(100, 1000, 1000000);
            circle2.Draw();

            IFigure rectangular2 = new Rectangular(100, 150, 1000000, 500000);
            rectangular2.Draw();
        }
    }
}

using System;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(0, 0);

            point.PrintPoint();
           // Console.WriteLine(point.Print());
           // Console.WriteLine("Rectangle: ");
            Rectangle rectangle = new Rectangle(12, 7, 15, 15);

            rectangle.PrintRectangle();
           // Console.WriteLine(rectangle.Print());

            //Console.WriteLine("Square: ");
            Square square = new Square(4, 7, 7);

            square.PritSquare();
            // Console.WriteLine(square.Print());
            Console.ReadKey();
            
        }
    }
}

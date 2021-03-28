using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Point : Shape
    {
        public override double Area { get; set; }
        public override double Perimeter { get; set; }

        public Point(int CoordX, int CoordY, double Area = 0, double Perimeter = 0) : base(Area, Perimeter, CoordX, CoordY)
        {
            this.Area = Area;
            this.Perimeter = Perimeter;
            this.basePoint.CoordX = CoordX;
            this.basePoint.CoordY = CoordY;
        }

        public void PrintPoint()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(this.basePoint.CoordX, this.basePoint.CoordY);
            Console.WriteLine("*");
        }
    }
}

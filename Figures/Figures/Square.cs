using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Square : Shape
    {
        public double Side { get; set; }
        public override double Area { get; set; }
        public override double Perimeter { get; set; }

        ConsoleColor Color = ConsoleColor.Red;
        public Square(double Side, int CoordX, int CoordY, double Area = 0, double Perimeter = 0) : base(Area, Perimeter, CoordX, CoordY)
        {
            this.Side = Side;
            this.Area = Side * Side;
            this.Perimeter = 4 * Side;
            this.basePoint.CoordX = CoordX;
            this.basePoint.CoordY = CoordY;
        }


        public void PritSquare()
        {
            Console.CursorTop = this.basePoint.CoordY;
            Console.ForegroundColor = ConsoleColor.Cyan;

            for (int i = 0; i < this.Side; i++)
            {
                Console.CursorLeft = this.basePoint.CoordX;
                for (int j = 0; j < this.Side; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}

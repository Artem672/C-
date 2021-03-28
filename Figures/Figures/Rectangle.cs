using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public override double Area { get; set; }
        public override double Perimeter { get; set; }

        ConsoleColor Color = ConsoleColor.Red;
        public Rectangle(double Length,double Width, int CoordX, int CoordY, double Area = 0, double Perimeter = 0) : base(Area, Perimeter, CoordX, CoordY)
        {
            this.Length = Length;
            this.Width = Width;
            this.Area = Length * Width;
            this.Perimeter = 2 * (Length + Width);
            this.basePoint.CoordX = CoordX;
            this.basePoint.CoordY = CoordY;
        }


        public void PrintRectangle()
        {
            Console.CursorTop = this.basePoint.CoordY;
            Console.ForegroundColor = ConsoleColor.Cyan;

            for(int i = 0; i < this.Length;i++)
            {
                Console.CursorLeft = this.basePoint.CoordX;
                for(int j = 0; j < this.Width;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}

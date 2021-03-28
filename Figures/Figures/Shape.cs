using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    abstract class Shape
    {
        public Position basePoint = new Position();
        
        public ConsoleColor color { get; set; }

        public abstract double Area { get; set; }

        public abstract double Perimeter { get; set; }

        public Shape(double Area, double Perimeter, int CoordX , int CoordY )
        {
            this.Area = Area;
            this.Perimeter = Perimeter;
            basePoint.CoordX = CoordX;
            basePoint.CoordY = CoordY;
        }

        public virtual string Print()
        {
            return $"Name:  {this.GetType().Name}\nArea:  {this.Area}\nPerimeter:  {this.Perimeter}";
        }


    }
}

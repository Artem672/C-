using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Position
    {
        public int CoordX { get; set; }
        public int CoordY { get; set; }

        public Position(int CoordX = 0, int CoordY = 0)
        {
            this.CoordX = CoordX;
            this.CoordY = CoordY;
        }
    }
}

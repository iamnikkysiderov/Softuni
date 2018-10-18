using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boxes
{
    class Box
    {
        public int UpperLeftX { get; set; }

        public int UpperLeftY { get; set; }

        public int UpperRightX { get; set; }

        public int UpperRightY { get; set; }

        public int BottomLeftX { get; set; }

        public int BottomLeftY { get; set; }

        public int BottomRightX { get; set; }

        public int BottomRightY { get; set; }

        public int Width()
        {
            return Math.Abs(UpperLeftX - UpperRightX);
        }

        public int Height()
        {
            return Math.Abs(UpperRightY - BottomRightY);
        }
    }
}

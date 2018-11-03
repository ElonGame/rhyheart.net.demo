using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Structs
{
    public struct StructPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public StructPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}

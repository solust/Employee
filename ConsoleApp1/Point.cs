using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Point
    {
        int x;
        int y;
        int z;

        public Point() { x = 0; y = 0; z = 0; }
        public Point(int xt,int yt) { x = xt; y = yt; z = 0;}
        public Point(int xt, int yt, int zt) { x = xt; y = yt; z = zt; }

        static public double LengthPoints(Point t1, Point t2)
        {
            return Math.Sqrt((t2.x - t1.x) * (t2.x - t1.x) + (t2.y - t1.y) * (t2.y - t1.y) + (t2.z - t1.z) * (t2.z - t1.z));
        }
    }
}

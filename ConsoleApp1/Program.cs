using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace test
{
    class Point
    {
        public int X;
        public int Y;

        public static int sX;
        public static int sY;

        public Point (int X, int Y)
        {
            Point.sX = this.X = X;
            Point.sY = this.Y = Y;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Point (X:1, Y:2);
            var b = new Point (X:3, Y:4);

            Console.WriteLine((a.X, a.Y));
            Console.WriteLine((b.X, b.Y));
            
            Console.WriteLine((Point.sX, Point.sY));
        }
    }
}




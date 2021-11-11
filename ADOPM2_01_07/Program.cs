using System;

namespace ADOPM2_01_07
{
    class Program
    {
        public class Rectangle
        {
            public long Width { get; set; }
            public long Height { get; set; }
            public long Area1() { return Width * Height; }
            public long Area2() => Width * Height;
            public static long Area(long Width, long Height) => Width * Height;
        }
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle { Width = 100, Height = 100 };
            Rectangle r2 = new Rectangle { Width = 200, Height = 200 };
            Console.WriteLine(r1.Area1()); // 10000
            Console.WriteLine(r2.Area2()); // 40000
            Console.WriteLine(Rectangle.Area(300, 100)); //30000
        }
    }
 }
//Excercises:
//1.    Modify Area2() so it becomes a property instead of a Method and call it Area. Use it to print out the area.
//2.    Create an expression bodied method Sum (Rectangle r) that takes a Rectange as an argument and return the sum of the Areas
//      of the object instance and the argument.
//3.    Create an expression bodied method Equal (...) that returns true if two reactangles are equal.
//4     Implement Equal (...) as a static Method as well as a non-static Method. Have one call the other as part of its implementation. 


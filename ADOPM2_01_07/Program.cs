using System;

namespace ADOPM2_01_07
{
    class Program
    {
        public class Rectangle
        {
            public long Width { get; set; }
            public long Height { get; set; }

            public long Area1()
            {
                return Rectangle.Area(Width, Height);
            }
            public long Area2() => Rectangle.Area(Width, Height);

            public static long Area(long Width, long Height)
            {
                return Width * Height;
            }

            public void SetWH(long Width, long Height=500)
            {
                this.Width = Width;
                this.Height = Height;
            }

            public static Rectangle SetWH1(long Width, long Height)
            {
                var r = new Rectangle { Width = Width, Height = Height };
                return r;
            }
            public static Rectangle CreateRandom()
            {
                var rnd = new Random();
                return new Rectangle { Height = rnd.Next(100, 300), Width = rnd.Next(50, 150) };
            }

        }
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle { Width = 100, Height = 100 };
            Rectangle r2 = new Rectangle { Width = 200, Height = 200 };
            Console.WriteLine(r1.Area1()); // 10000
            Console.WriteLine(r2.Area2()); // 40000

            r2.SetWH(1000, 400);
            Console.WriteLine(r2.Area1());

            /*
            Console.WriteLine(Rectangle.Area(300, 100)); //30000

            var r = new Rectangle();
            var r3 = Rectangle.CreateRandom();
            */
        }
    }
 }
//Excercises:
//1.    Modify Area2() so it becomes a property instead of a Method and call it Area. Use it to print out the area.

//2.    Create an expression bodied method Sum (Rectangle r) that takes a Rectange as an argument and return the sum of the Areas
//      of the current instance and the argument instance.

//3.    Create an expression bodied method Equal (...) that returns true if two reactangles are equal.
//4     Implement Equal (...) as a static Method as well as a non-static Method. Have one call the other as part of its implementation. 


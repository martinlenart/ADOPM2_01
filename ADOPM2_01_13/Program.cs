using System;

namespace ADOPM2_01_13
{
    class Program
    {
        public class RectangleClass
        {
            public long Width { get; set; }
            public long Height { get; set; }
            public long Area => Width * Height;
            public static bool operator ==(RectangleClass r1, RectangleClass r2) => (r1.Width, r1.Height) == (r2.Width, r2.Height);
            public static bool operator !=(RectangleClass r1, RectangleClass r2) => (r1.Width, r1.Height) != (r2.Width, r2.Height);
            public static RectangleClass operator +(RectangleClass r1, RectangleClass r2) => 
                new RectangleClass {Height = r1.Height + r2.Height, Width = r1.Width + r2.Width};

        }
        static void Main(string[] args)
        {
            RectangleClass r1 = new RectangleClass { Width = 100, Height = 100 };
            RectangleClass r2 = new RectangleClass { Width = 200, Height = 200 };

            Console.WriteLine(r1 == r2); // false
            Console.WriteLine(r1 != r2); // true

            var r3 = r1 + r2;
            r1 += r2;
            Console.WriteLine(r3.Height);
            Console.WriteLine(r1.Height);
        }
    }
}
//Excercises:
//1.    Create a RectangleStruct with same functionallity as RectangleClass


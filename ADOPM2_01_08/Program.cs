using System;

namespace BOOPM3_01_08
{
    class Program
    {
        public class Rectangle
        {
            public long Width { get; set; }
            public long Height { get; set; }
            public long Area => Width * Height;

            public double Diagonal
            {
                get
                {
                    return Diagonal();

                    //local method
                    double Diagonal() => Math.Sqrt(Width * Width + Height * Height);
                }
            }
            public static double Diag(long Width, long Height) // Name conflict - cannot be called Diagonal
            {
                return Diagonal();

                //local method
                double Diagonal() => Math.Sqrt(Width * Width + Height * Height); // No name conflict
            }
        }
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle { Width = 100, Height = 100 };
            Console.WriteLine(r1.Area);     // 10000
            Console.WriteLine(r1.Diagonal); // 141,42...
            Console.WriteLine(Rectangle.Diag(100, 100)); //141,42
            Console.WriteLine(Rectangle.Diag(300, 100)); //316,23
        }
    }
    //Excercises:
    //1.    Modify above code to apply DRY when calculating the diagonal.
    //      I.e, the calculation should only be done in one place.

}

using System;

namespace ADOPM2_01_15
{
	// Using partial class to separate implemention of larger classes
	public partial class RectangleClass
	{
		public long Width { get; set; }
		public long Height { get; set; }
		public long Area => Width * Height;
	}
	public partial class RectangleClass
	{
		public static bool operator ==(RectangleClass r1, RectangleClass r2) => (r1.Width, r1.Height) == (r2.Width, r2.Height);
		public static bool operator !=(RectangleClass r1, RectangleClass r2) => (r1.Width, r1.Height) != (r2.Width, r2.Height);
		public static RectangleClass operator +(RectangleClass r1, RectangleClass r2) =>
			new RectangleClass { Height = r1.Height + r2.Height, Width = r1.Width + r2.Width };
	}
	class Program
    {
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
//1.    Separate the two implementations of RectangleClass into two separate files (same namespace), compile and run
//2.	Implement a method Diagonal in one of the partial implementation where the == and != are overridden.
//		Print out the Diagonal


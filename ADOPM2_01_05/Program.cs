using System;

namespace ADOPM2_01_05
{
	class Program
	{
		//Base class or Parent class. 
		public abstract class Shape : IEquatable<Shape>
		{
			public double Width { get; set; }
			public double Height { get; set; }
			public abstract bool Equals(Shape s1);
		}
		// Triangle is derived from Shape.  
		public class Triangle : Shape, IEquatable<Shape>
		{
			public double Area() => Width * Height / 2;
			public override bool Equals(Shape t1) => (this.Width, this.Height) == (t1.Width, t1.Height);
		}
		// Rectangle is derived from Shape
		public class Rectangle : Shape, IEquatable<Shape>
		{
			public double Area() => Width * Height;
			public override bool Equals(Shape r1) => (this.Width, this.Height) == (r1.Width, r1.Height);
		}
		static void Main(string[] args)
		{
			var r1 = new Rectangle() { Height = 100, Width = 200 };
			var r2 = new Rectangle() { Height = 100, Width = 200 };
			Console.WriteLine(r1.Equals(r2)); // true
		}
	}
}

using System;

namespace ADOPM2_01_12
{
    class Program
    {
		struct RectangleStruct
		{
			public float Width { get; set; }
			public float Height { get; set; } 

			public RectangleStruct(float width, float height)
			{
				Width = width;
				Height = height;
			}
			public void Deconstruct(out float width, out float height)
			{
				width = Width;
				height = Height;
			}
		}
		class RectangleClass
		{
			public float Width { get; set; }
			public float Height { get; set; }

			public RectangleClass(float width, float height)
			{
				Width = width;
				Height = height;
			}
			public void Deconstruct(out float width, out float height)
			{
				width = Width;
				height = Height;
			}
		}
		static void Main(string[] args)
        {
			var rs1 = new RectangleStruct(3, 4);
			
			(float width1, float height1) = rs1; // Tuple like Deconstruction
			Console.WriteLine($"{nameof(width1)}: {width1}  {nameof(height1)}: {height1}"); // 3 4

			var rc1 = new RectangleClass(3, 4);

			(float width2, float height2) = rc1; // Tuple like Deconstruction
			Console.WriteLine($"{nameof(width2)}: {width2}  {nameof(height2)}: {height2}"); // 3, 4

			// create tuples and compare
			Console.WriteLine((width1, height1) == (width2, height2)); // true	

			// use discard for members of no interest
			(_, float height3) = rc1; // Tuple like Deconstruction
			Console.WriteLine($"{nameof(height3)}: {height3}"); // 4
		}
	}
}
//Excercises:
//1.	Make the WineClass and WineStruct from ADOPM2_01_10 deconstructable
//2.    Modify RectangleStruct and RectangleClass to be immutable and deconstructable

using System;

namespace ADOPM2_01_01
{
    class Program
    {
		public struct valueTypePoint { public int X, Y; }
		public class referenceTypePoint { public int X, Y; }

        static void Main(string[] args)
        {
			valueTypePoint vp1 = new valueTypePoint();
			vp1.X = 7;

			valueTypePoint vp2 = vp1;  // Assignment causes structual copy
			valueTypePoint vp3 = vp1;  

			vp1.X = 9;                  // Change vp1.X
			Console.WriteLine(vp1.X);  // 9
			Console.WriteLine(vp2.X);  // 7

			//Structual Equality
			Console.WriteLine(vp1.Equals(vp2)); // False
			Console.WriteLine(vp3.Equals(vp2)); // True

			referenceTypePoint rp1 = new referenceTypePoint();
			rp1.X = 7;

			referenceTypePoint rp2 = rp1; // Reference copy
			rp2.X = 9;                  // Change rp1.X

			//Referential Equality
			Console.WriteLine(rp1.X);  // 9
			Console.WriteLine(rp2.X);  // 9
			Console.WriteLine(rp1.Equals(rp2)); // True
		}
	}
}
//Excercises:
//1.	Declare a variable of type referenceTypePoint, rp4. Make rp4 a deep
//		copy of rp1. Explain the difference between shallow and deep copy for 
//		value types and reference types.

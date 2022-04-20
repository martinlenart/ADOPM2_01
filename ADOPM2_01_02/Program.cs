using System;

namespace ADOPM2_01_02
{
    class Program
    {
		public class Apple
		{
			public string Name;             // Instance field
			public static int NrInstances;  // Static field
			public static float Heaviest = 0;
			public Apple(string n, float weight)
			{
				Name = n;                      // Assign the instance field

				NrInstances = NrInstances + 1; // Increment the static field

				if (weight > Heaviest)
					Heaviest = weight;
			}
		}
		static void Main(string[] args)
		{

			Apple a1 = new Apple("Pink Lady", 100);
			Apple a2 = new Apple("Discovery", 135);

			
			Console.WriteLine(a1.Name);      // Pink Lady
			Console.WriteLine(a2.Name);      // Discovery

			Console.WriteLine(Apple.NrInstances);   // 2
													//
			var rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
				new Apple("Bad Apple", rnd.Next(100, 235));
            }
			Console.WriteLine(Apple.NrInstances);   //
			Console.WriteLine(Apple.Heaviest);   //
		}
	}
}
//Exercises:
//1.	Add 2 public static data members, float Heaviest, float Lightest.  	
//		Modify the code so it also keept track of the heaviest and lightest Apple object instanciated. 
//		Write the weight of the heaviest and lightest Apple object instantiated.
//		
//		Hint: Add weight as a non static data member and as a parameter to the constructor.
//		Add code in the constructor that keeps track of heviest and lightest apple.		


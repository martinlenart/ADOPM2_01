using System;

namespace ADOPM2_01_12a
{
    class Program
    {
        class ProtectedArray
		{
			private int[] myArray = { 1, 2, 3, 4, 5 };

            public int this[int idx] { get { return myArray[idx]; } }
        }

        class UnProtectedArray
        {
            public int[] myArray { get; } = { 1, 2, 3, 4, 5 };
        }

		static void Main(string[] args)
        {

            var upa = new UnProtectedArray();
            var pa = new ProtectedArray();

            upa.myArray[0] = 1000;
            Console.WriteLine(upa.myArray[0]); 
            Console.WriteLine(upa.myArray[4]);


            pa[0] = 1000;
            pa.myArray[0] = 1000;

            Console.WriteLine(pa[0]);
            Console.WriteLine(pa[4]);

        }
    }
}
//Excercises:
//1.	In Main try to modify the content of myArray in upa and in pa.
//2.    In Main print out the length of myArray in upa and pa. How would you do it?
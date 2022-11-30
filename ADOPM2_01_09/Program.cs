using System;

namespace BOOPM3_01_09
{
    class Program
    {
        public static class FooClass
        {
            public static string GetParameterTypes(int x) => "int";
            public static string GetParameterTypes(double x) => "double";
            public static string GetParameterTypes(int x, float y) => "int, float";
            public static string GetParameterTypes(float x, int y) => "float, int";

            //Illegal overloading, so compiler error
            //public static int GetParameterTypes(int x) => x;
            //public static (float, int) GetParameterTypes(float x, int y) => (x, y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FooClass.GetParameterTypes(123));       // int
            Console.WriteLine(FooClass.GetParameterTypes(123.0));     // double
            Console.WriteLine(FooClass.GetParameterTypes(123, 123F)); // int, float
            Console.WriteLine(FooClass.GetParameterTypes(123F, 123));	// float, int
        }
    }

    //Excercises:
    //1.    Implement two methods overloading with conflicting signature
    //2.    Implement two methods with non-conflicting signatures, but each has a local method,
    //      with exactly the same signature. Will this work?
}

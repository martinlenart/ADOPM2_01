using System;

namespace BOOPM3_01_09
{
    class Program
    {
        public static class FooClass
        {
            public static string Foo(int x) => "int";
            public static string Foo(double x) => "double";
            public static string Foo(int x, float y) => "int, float";
            public static string Foo(float x, int y) => "float, int";

            //Illegal overloading, so compiler error
            //public static int Foo(int x) => x;
            //public static (float, int) Foo(float x, int y) => (x, y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FooClass.Foo(123));       // int
            Console.WriteLine(FooClass.Foo(123.0));     // double
            Console.WriteLine(FooClass.Foo(123, 123F)); // int, float
            Console.WriteLine(FooClass.Foo(123F, 123));	// float, int
        }
    }

    //Excercises:
    //1.    Implement two methods overloading with conflicting signature
    //2.    Implement two methods with non-conflicting signatures, but each has a local method,
    //      with exactly the same signature. Will this work?
}

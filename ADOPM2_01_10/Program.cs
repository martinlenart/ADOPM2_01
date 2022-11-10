using System;

namespace ADOPM2_01_10
{
    class Program
    {
        public struct WineStruct
        {
            public decimal Price { get; set; }
            public int Year { get; set; }

            //New in C# 10 - parameterless constructor in struct
            public WineStruct() { Price = 200; Year = 1964; }

            public WineStruct(decimal price) 
            { 
                Price = price; 
                Year = default; 
            }
            public WineStruct(decimal price, int year) : this(price)
            {
                Year = year;
            }
        }
        public class WineClass
        {
            public decimal Price { get; set; } = default;
            public int Year { get; set; } = default;

            public WineClass() { Price = 200; Year = 1964; }
            public WineClass(decimal price)
            {
                Price = price;
            }

            public WineClass(decimal Price, int year):this(Price)
            {
                Year = year; 
            }
        }
        static void Main(string[] args)
        {
            var ws1 = new WineStruct(78);
            var ws2 = new WineStruct(78, 2001);
  
            var wc1 = new WineClass(78);
            var wc2 = new WineClass(78, 2001);

            Console.WriteLine(ws1.Equals(ws2));                 // false
            Console.WriteLine(ws1.Equals(ws2));                 // false
            ws1.Year = 2001;
            Console.WriteLine(ws1.Equals(ws2));                 // true  Note

            Console.WriteLine(wc1.Equals(wc2));                 // false
            Console.WriteLine(wc1.Equals(wc2));                 // false
            wc1.Year = 2001;
            Console.WriteLine(wc1.Equals(wc2));                 // false Note

            //Using Object initialization
            var ws3 = new WineStruct { Price = 250, Year = 1964 };
  
            var wc3 = new WineClass { Price = 250};
            Console.WriteLine(wc3.Price);
            Console.WriteLine(wc3.Year);
        }
    }

    //Excercises:
    //1.    Explain the difference in the last compare ws1.Equals(ws2) vs last compare wc1.Equals(wc2) (marked Note)

    //2.    Add a property string Name to both WineClass and WineStruct. Modify the constructors in
    //      WineClass to set Name, Price and Year to your favorite wine.

    //3.    Create an instance of your favorite wine in a variable of type WineStruct and WineClass
}

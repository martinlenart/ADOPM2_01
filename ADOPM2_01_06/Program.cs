using System;

namespace ADOPM2_01_06
{
	class Program
	{
		private class Stock
		{
			decimal _currentPrice = 1;      // private "backing" field
			public decimal CurrentPrice     // public property
			{
				get => _currentPrice;
				set
				{
					if (value > 0) _currentPrice = value;
					else throw new Exception("Wrong Price");
				}
			}

			public decimal SharesOwned { get; private set; } = 50;  // Automatic properties initialization

			public decimal Worth
			{
				get => _currentPrice * SharesOwned;
				init => SharesOwned = value / _currentPrice;  // Can only be set at initialization time
			}
            public Stock()
            {
				Worth = 5000;
            }
		}
		static void Main(string[] args)
		{
			var stock1 = new Stock();

			Console.WriteLine(stock1.Worth);         // 50
			Console.WriteLine(stock1.SharesOwned);   // 50

			var stock2 = new Stock { CurrentPrice = 50, Worth = 10000 }; //object initialization of public properties
			Console.WriteLine(stock2.Worth);         // 10000
			Console.WriteLine(stock2.SharesOwned);   // 200

			stock2.CurrentPrice = 3.0M;
		}
	}
}
//Excercises:
//1.	Can SharesOwned be initialized through object initialization, i.e. new Stock { SharesOwned = 100 };?

//2.	Make public (should it be static?) readonly members to return nr of Stocks objects created.
//		Create a few Stocks using object initialization, and write out number of Stock instances created

//3.	Modify code to write the Worth of the instance of Stock with the highest worth created. 


using System;

namespace ADOPM2_01_14
{
	// Using partial class to separate implemention in auto generated files

	// auto generated file
	partial class PaymentForm
	{
		public PaymentForm(decimal amount)
		{
			ValidatePayment(amount);
			// ...
		}
		partial void ValidatePayment(decimal amount);
	}

	// In hand-authored file
	partial class PaymentForm
	{
		partial void ValidatePayment(decimal amount)
		{
			if (amount < 100)
				throw new ArgumentOutOfRangeException("amount", "Amount too low!");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			var paymentForm = new PaymentForm(50); //Exception
		}
	}
}

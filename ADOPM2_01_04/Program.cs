using System;
using System.Threading.Tasks;
using System.Threading;

namespace ADOPM2_01_04
{
    class Program
    {
        public class constVsStaticReadonly
        {
            public const double twoPI = 2 * System.Math.PI;
            public static readonly DateTime staticCreationTime = DateTime.Now;
        }
        static async Task Main(string[] args)
        {
            Console.WriteLine(constVsStaticReadonly.twoPI); // 6.28... Will never change
            Console.WriteLine(constVsStaticReadonly.staticCreationTime); // time of static staticCreationTime init
            await Task.Delay(5000);
            //Thread.Sleep(5000);// Delay 5 sec   
            Console.WriteLine(constVsStaticReadonly.staticCreationTime); // Same time as above
        }
    }
}
//Exercises:
//1.    In a program you need to make a configuration class that keeps track of the
//      url to a database where you read customer data. Do you best implement it as
//      a constant or static readonly in your configuration class?

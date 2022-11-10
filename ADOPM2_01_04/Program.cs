using System;
using System.Threading.Tasks;
using System.Threading;

namespace ADOPM2_01_04
{
    class Program
    {
        public class constVsStaticReadonly
        {
            public const double twoPI = 2 * System.Math.PI;                     //const
            public static readonly DateTime staticCreationTime = DateTime.Now;  //static readonly
        }
        static async Task Main(string[] args)
        {
            Console.WriteLine(constVsStaticReadonly.twoPI); // 6.28... Will never change

            // time of static staticCreationTime instance creation
            Console.WriteLine(constVsStaticReadonly.staticCreationTime); 

            //Sleep for 5 seconds
            await Task.Delay(5000);
            Console.WriteLine(constVsStaticReadonly.staticCreationTime); // Same time as above
        }
    }
}
//Exercises:
//1.    In a program you need to make a configuration class that keeps track of the
//      url to a database where you read customer data. Do you best implement it as
//      a constant or static readonly in your configuration class?

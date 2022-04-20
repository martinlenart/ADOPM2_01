using System;

namespace ADOPM2_01_03
{
    class Program
    {
        public struct valueTypePoint { public int X, Y; }
 
        public readonly struct immutableValueTypePoint 
        { 
            readonly public int X, Y; 
            public immutableValueTypePoint(int X, int Y)
            { 
                this.X = X;
                this.Y = Y;
            }
        }

        public class referenceTypePoint { public int X, Y; }
        
          public class immutableReferenceTypePoint 
          {
              readonly public int X, Y;
              public immutableReferenceTypePoint(int X, int Y)
              {
                  this.X = X;
                  this.Y = Y;
              }
            public immutableReferenceTypePoint SetX(int X, int Y)
            {
                var newrp = new immutableReferenceTypePoint(X, Y);
                return newrp;
            }
          }
         
        static void Main(string[] args)
        {
            var vp1 = new valueTypePoint { X = 3, Y = 5 };
            var rp1 = new referenceTypePoint { X = 3, Y = 5 };

            //demonstrate mutable
            vp1.X = rp1.X = 10;
            Console.WriteLine($"{nameof(vp1)}={(vp1.X, vp1.Y)}"); // I convert to tuple in printout
            Console.WriteLine($"{nameof(rp1)}={(rp1.X, vp1.Y)}"); // I use nameof() for easy renaming

            var imvp1 = new immutableValueTypePoint (X:3, Y:5); // named parameters
            var imrp1 = new immutableReferenceTypePoint(3, 5) ; // positional parameters

            //demonstrate mutable
            //imvp1.X = imrp1.X = 10;     // Compiler error as the types are immutable
            Console.WriteLine($"{nameof(imvp1)}={(imvp1.X, imvp1.Y)}");
            Console.WriteLine($"{nameof(imrp1)}={(imrp1.X, imrp1.Y)}");
        }
    }
}
//Exercises:
//1.    Write a constructor to immutableReferenceTypePoint so the code
//      imrp2 = new immutableReferenceTypePoint();
//      creates a point that is initiated to X=0 and Y=0
//2.    Write a public function member (a method), Add(..), in the class immutableReferenceTypePoint
//      that takes a parameter of type immutableReferenceTypePoint, that returns a
//      value of type immutableReferenceTypePoint whose
//          X = X (of the instance) + X (of the parameter) and
//          Y = Y (of the instance) + Y (of the parameter)
//3.	Is the Apple type in BOOPM3_02  mutable or immutable? 
//		Create a new Apple type with oposite mutability. 
//		Demonstrate mutability and immutability by assignment and printout.

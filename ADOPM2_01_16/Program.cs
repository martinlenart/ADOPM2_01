using System;

namespace ADOPM2_01_16
{
    class Program
    {
        public class Panda
        {
            public string Name { get; init; }
            public Panda Mate { get; set; }

            public Panda(string Name) => this.Name = Name;
            public void Marry(Panda partner)
            {
                Mate = partner;
                partner.Mate = this;
            }
        }
        static void Main(string[] args)
        {
            Panda p1 = new Panda("Bill");
            p1.Marry(new Panda("Anne"));

            Console.WriteLine($"{p1.Name}'s class is of type {nameof(Panda)}"); // Bill's class is of type Panda
            Console.WriteLine($"{p1.Name}'s {nameof(p1.Mate)} is {p1.Mate.Name}"); // Bill's Mate is Anne
        }
    }
}
//Excercises:
//1.    Modify class Panda to allow the property Name to be set also through object initialization.
//      Hint. Class constructor.
//2.    Create an instance of Panda using only object initialization

using System;

namespace ADOPM2_01_16
{
    class Program
    {
        public class Panda
        {
            public string name { get; init; }

            public Panda partner { get; set; }


            public Panda(string name)
            {
                this.name = name;
            }
            public void Marry(Panda partner)
            {
                this.partner = partner;
                partner.partner = this;
            }
        }

        static void Main(string[] args)
        {
            Panda p1 = new Panda ("Bill");
            p1.Marry(new Panda("Anne"));

            Console.WriteLine($"{p1.name}'s class is of type {nameof(Panda)}"); // Bill's class is of type Panda
            Console.WriteLine($"{p1.name}'s {nameof(p1.partner)} is {p1.partner.name}"); // Bill's Mate is Anne
        }
    }
}
//Excercises:
//1.    Modify class Panda to allow an instance to be created using object initialization.
//      Hint. default class constructor - why?

//2.    Create an instances of Panda using only object initialization

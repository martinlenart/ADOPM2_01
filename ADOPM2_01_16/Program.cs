using System;

namespace ADOPM2_01_16
{
    class Program
    {
        public class Panda2
        {
            public string Name { get; init; }
            public Panda2 BestFriend { get; set; }

            public Panda2(string Name) => this.Name = Name;
            public void Marry(Panda2 partner)
            {
                BestFriend = partner;
                partner.BestFriend = this;
            }
        }
        static void Main(string[] args)
        {
            Panda2 p1 = new Panda2("Bill");
            p1.Marry(new Panda2("Anne"));

            Console.WriteLine($"{p1.Name}'s class is of type {nameof(Panda2)}"); // Bill's class is of type Panda
            Console.WriteLine($"{p1.Name}'s {nameof(p1.BestFriend)} is {p1.BestFriend.Name}"); // Bill's Mate is Anne
        }
    }
}
//Excercises:
//1.    Modify class Panda to allow the property Name to be set also through object initialization.
//      Hint. Class constructor.
//2.    Create an instance of Panda using only object initialization

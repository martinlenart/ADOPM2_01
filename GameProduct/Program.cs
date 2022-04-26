using System;

namespace GameProduct // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(GameProduct.CreateRandom());
            //Console.WriteLine(GameProduct.CreateRandom());

            var gp = GameProduct.CreateRandom();
            var gp1 = new GameProduct(gp);
            var gp2 = new GameProduct(gp);


            Console.WriteLine(gp1.Equals(gp2));
            Console.WriteLine(gp1 == gp2);

            Console.WriteLine();
            Console.WriteLine(gp1);
            Console.WriteLine(gp2);



            Console.ReadKey();
            var games = GameProduct.CreateRandomList(10_000);
            Console.WriteLine($"Nr of Games: {games.Count()}");
            Console.ReadKey();


            games.Sort();
            foreach (var item in games.TakeLast(20))
            {
                Console.WriteLine(item);
            }
        }
    }
}



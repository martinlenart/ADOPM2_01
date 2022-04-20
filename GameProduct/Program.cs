// See https://aka.ms/new-console-template for more information
Console.WriteLine(GameProduct.CreateRandom());
Console.WriteLine(GameProduct.CreateRandom());

var games = GameProduct.CreateRandomList(10_000);
Console.WriteLine($"Nr of Games: {games.Count()}");
Console.ReadKey();
foreach (var item in games.TakeLast(10))
{
    Console.WriteLine(item);
}



[Flags]
public enum GamePlatform {
    unknown = 0,
    XBox = 0b1,
    Wii = 0b1<<1,
    PlayStation = 0b1<<2,
    final = 0b1<<3
}

[Flags]
public enum GameCategory
{
    unknown = 0,
    Adventure = 0b1,
    Children = 0b1<<1,
    Action = 0b1<<2,
    final = 0b1<<3
}

public class GameProduct
{
    public GamePlatform Platform { get; set; }
    public GameCategory Category { get; set; }

    public string? Name { get; set; }
    public DateOnly? ReleaseDate { get; set; }
    public decimal Price { get; set; }
    public int StockLevel { get; set; }

    public override string ToString()
    {
        string sRet = $"Name: {Name}\n";
        sRet += $"Category: {Category}   Platform: {Platform}\n";
        sRet += $"ReleaseDatum: {ReleaseDate}\n";
        sRet += $"Price: {Price:C2}  StockLevel: {StockLevel}\n\n";
        return sRet;
    }

    public static GameProduct CreateRandom()
    {
        var rnd = new Random();

        while (true)
        {
            var _names = "Call of duty, Kalle kunskap, Super Mario, Mario cart".Split(',');
            var p = (GamePlatform)rnd.Next(1, (int)GamePlatform.final);
            var c = (GameCategory)rnd.Next(1, (int)GameCategory.final);
            var n = _names[rnd.Next(0, _names.Length)];

            DateOnly rd;
            try
            {
                rd = new DateOnly(rnd.Next(2022, 2024), rnd.Next(1, 13), rnd.Next(1, 31));
                var gp = new GameProduct
                {
                    Platform = p,
                    Category = c,
                    Name = n,
                    ReleaseDate = rd,
                    Price = rnd.Next(50, 450),
                    StockLevel = rnd.Next(0, 50)
                };
                return gp;
            }
            catch { }
        }
    }
    public static List<GameProduct> CreateRandomList(int NrOfItems)
    {
        var myList = new List<GameProduct>();
        for (int i = 0; i < NrOfItems; i++)
        {
            myList.Add(GameProduct.CreateRandom());
        }
        return myList;
    }
}



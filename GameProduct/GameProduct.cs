using System;
namespace GameProduct
{
    [Flags]
    public enum GamePlatform
    {
        unknown = 0,
        XBox = 0b1,
        Wii = 0b1 << 1,
        PlayStation = 0b1 << 2,
        final = 0b1 << 3
    }

    [Flags]
    public enum GameCategory
    {
        unknown = 0,
        Adventure = 0b1,
        Children = 0b1 << 1,
        Action = 0b1 << 2,
        final = 0b1 << 3
    }

    public class GameProduct : IEquatable<GameProduct>, IComparable<GameProduct>
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

        public bool Equals(GameProduct? other) => (this.Platform, this.Category, this.Name, this.ReleaseDate, this.Price, this.StockLevel) ==
            (other.Platform, other.Category, other.Name, other.ReleaseDate, other.Price, other.StockLevel);

        public override bool Equals(object? obj) => Equals(obj as GameProduct);
        public override int GetHashCode() => (this.Platform, this.Category, this.Name, this.ReleaseDate, this.Price, this.StockLevel).GetHashCode();

        public static bool operator ==(GameProduct gp1, GameProduct gp2) => gp1.Equals(gp2);
        public static bool operator !=(GameProduct gp1, GameProduct gp2) => !gp1.Equals(gp2);

        public int CompareTo(GameProduct other) => this.Price.CompareTo(other.Price);

        public GameProduct()
        {

        }
        public GameProduct(GameProduct org)
        {
            this.Platform = org.Platform;
            this.Category = org.Category;
            this.Name = org.Name;
            this.ReleaseDate = org.ReleaseDate;
            this.Price = org.Price;
            this.StockLevel = org.StockLevel;
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
}


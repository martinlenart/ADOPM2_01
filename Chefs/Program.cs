// See https://aka.ms/new-console-template for more information
static void FavoritesToConsole(List<Chef> theList)
{
    foreach (var item in theList)
    {
        Console.WriteLine(item);
        if (item is GermanChef gf)
        {
            Console.WriteLine($"And my name is {gf.Age}");
        }

    }
}

Console.WriteLine("Hello, World!");

var chef = new Chef();
Console.WriteLine(chef.FavoriteDish);

var chef1 = new GermanChef();
Console.WriteLine(chef1.FavoriteDish);

Chef chef2 = new GermanChef();
Console.WriteLine(chef2.FavoriteDish);

List<Chef> myChefs = new List<Chef>();
myChefs.Add(new GermanChef());
myChefs.Add(new ItalianChef());
myChefs.Add(new GermanChef());
myChefs.Add(new ItalianChef());
myChefs.Add(new GermanChef());
myChefs.Add(new SwedishChef());

FavoritesToConsole(myChefs);


public interface IChef
{
    public string? Name { get; set; }
    public string? FavoriteDish { get; set; }
}

public class Chef : IChef
{
    virtual public string? Name { get; set; }
    virtual public string? FavoriteDish { get; set; } = "snails";
    public override string ToString()
    {
        return $"Hello, my name is {Name}. I just love {FavoriteDish}";
    }
}
public class GermanChef:Chef
{
    override public string? Name { get; set; } = "Franz";
    override public string? FavoriteDish { get; set; } = "wurst";

    public int Age = 45;
}
public class ItalianChef : Chef
{
    override public string? Name { get; set; } = "Mauro";
 
    public int Age = 35;
}
public class SwedishChef : ItalianChef
{
    override public string? Name { get; set; } = "Lars";
}



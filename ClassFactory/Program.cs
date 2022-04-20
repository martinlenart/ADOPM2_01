// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var f1 = new ContactSheet();
Console.WriteLine(f1);

var f2 = ContactSheet.CreateRandom();
Console.WriteLine(f2);

List<ContactSheet> myFriends = new List<ContactSheet>();
for (int i = 0; i < 10_000; i++)
{
    myFriends.Add(ContactSheet.CreateRandom());
}

foreach (var item in myFriends.TakeLast(10))
{
    Console.WriteLine(item);
}

Console.WriteLine();
foreach (var item in ContactSheet.CreateInStockholm(10))
{
    Console.WriteLine(item);
}

foreach (var item in typeof(FriendLevel).GetEnumNames())
{
    Console.WriteLine(item);
}


public enum FriendLevel { unknown, not_at_all, soso, kindof, good, best, final}

[Flags]
public enum PreferedWayOfContact
{
  email = 0b1,
  twitter = 0b1<<1,
  facebook = 0b1<<2,
  mobile = 0b1<<3,
  final = 0b1 << 4
}


public class ContactSheet
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? City { get; set; }
    public FriendLevel Level { get; set; }

    public PreferedWayOfContact WayToContact { get; set; }

    public override string ToString() => $"{FirstName} {LastName}, {City}, {Level}, WayToContact: {WayToContact}";

    public static ContactSheet CreateRandom()
    {
        var rnd = new Random();
        var _firstnames = "Martin, Max, Alexander, Linea, Lisa, Frida, Jessica".Split(',');
        var _lastnames = "Lenart, Andersson, Hernandez Ramir, Jonsson, Smith".Split(',');
        var _cities = "Gaevle, Stockholm, Malmoe".Split(',');

        var _friendlevel = rnd.Next((int)FriendLevel.unknown+1, (int)FriendLevel.final);
        var _waytocontact = rnd.Next(1, (int)PreferedWayOfContact.final);

        var cs = new ContactSheet
        {
            FirstName = _firstnames[rnd.Next(0, _firstnames.Length)],
            LastName = _lastnames[rnd.Next(0, _lastnames.Length)],
            City = _cities[rnd.Next(0, _cities.Length)],
            Level = (FriendLevel)_friendlevel,
            WayToContact = (PreferedWayOfContact)_waytocontact
        };
        return cs;
    }

    public static List<ContactSheet> CreateInStockholm(int NrOfFriends)
    {
        List<ContactSheet> myList = new List<ContactSheet>();
        for (int i = 0; i < NrOfFriends; i++)
        {
            var f = ContactSheet.CreateRandom();
            f.City = "Stockholm";
            myList.Add(f);
        }
        return myList;
    }
}


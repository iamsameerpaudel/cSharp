public class Human
{
    public string Name { get; set; }
    public string Sex { get; set; }
    public bool HasHead { get; set; }
    public bool HasNeck { get; set; }
    public bool HasTorso { get; set; }
    public int NoOfArms { get; set; }
    public int NoOfLegs { get; set; }


    public void DisplayDetails()
    {
        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine($"Sex: {Sex}");
        System.Console.WriteLine($"Head: {HasHead}");
        System.Console.WriteLine($"Neck: {HasNeck}");
        System.Console.WriteLine($"Torso: {HasTorso}");
        System.Console.WriteLine($"Arms: {NoOfArms}");
        System.Console.WriteLine($"Legs: {NoOfLegs}");
    }

}


public class HumanMaker
{
    private Human _human = new Human();


    public HumanMaker setName(string name)
    {
        _human.Name = name;
        return this;
    }
    public HumanMaker setSex(string sex)
    {
        _human.Sex = sex;
        return this;
    }
    public HumanMaker setHead(bool hasHead)
    {
        _human.HasHead = hasHead;
        return this;
    }
    public HumanMaker setNeck(bool hasNeck)
    {
        _human.HasNeck = hasNeck;
        return this;
    }
    public HumanMaker setTorso(bool hasTorso)
    {
        _human.HasTorso = hasTorso;
        return this;
    }
    public HumanMaker setArms(int NoOfArms)
    {
        _human.NoOfArms = NoOfArms;
        return this;
    }
    public HumanMaker setLegs(int NoOfLegs)
    {
        _human.NoOfLegs = NoOfLegs;
        return this;
    }
    public Human make()
    {
        return _human;
    }

}


class program
{
    public static void Main(string[] args)
    {
    Human h1 = new HumanMaker().setName("Sam").setHead(true).setNeck(true).setSex("male").setArms(2).setLegs(2).setTorso(true).make();
        h1.DisplayDetails();

    }
}
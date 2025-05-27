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
        System.Console.WriteLine("");
    }

}

public class Director
{
    private IHumanMaker _maker;
    public Director(IHumanMaker maker)
    {
        _maker = maker;
    }

    public Human MakeMan(string name)
    {
        return _maker.setName(name).setSex("male").setHead(true).setNeck(true).setTorso(true).setArms(2).setLegs(2).make();
    }
    public Human MakeWoman(string name)
    {
        return _maker.setName(name).setSex("female").setHead(true).setNeck(true).setTorso(true).setArms(2).setLegs(2).make();
    }
    public void Display()
    {
        _maker.Display();
    }

}

public interface IHumanMaker
{
    IHumanMaker setName(string name);
    IHumanMaker setSex(string sex);
    IHumanMaker setHead(bool hasHead);
    IHumanMaker setNeck(bool hasNeck);
    IHumanMaker setTorso(bool hasTorso);
    IHumanMaker setArms(int NoOfArms);
    IHumanMaker setLegs(int NoOfLegs);
    Human make();
    void Display();
}

public class HumanMaker : IHumanMaker
{
    private Human _human = new Human();

    public IHumanMaker setName(string name)
    {
        _human.Name = name;
        return this;
    }
    public IHumanMaker setSex(string sex)
    {
        _human.Sex = sex;
        return this;
    }
    public IHumanMaker setHead(bool hasHead)
    {
        _human.HasHead = hasHead;
        return this;
    }
    public IHumanMaker setNeck(bool hasNeck)
    {
        _human.HasNeck = hasNeck;
        return this;
    }
    public IHumanMaker setTorso(bool hasTorso)
    {
        _human.HasTorso = hasTorso;
        return this;
    }
    public IHumanMaker setArms(int NoOfArms)
    {
        _human.NoOfArms = NoOfArms;
        return this;
    }
    public IHumanMaker setLegs(int NoOfLegs)
    {
        _human.NoOfLegs = NoOfLegs;
        return this;
    }
    public Human make()
    {
        var builtHuman = _human;
        _human = new Human();
        return builtHuman;
    }
    public void Display()
    {
        _human.DisplayDetails();
    }

}


class program
{
    public static void Main(string[] args)
    {
        Director d1 = new Director(new HumanMaker());
        Human man = d1.MakeMan("Sameer");
        man.DisplayDetails();

        Human woman = d1.MakeWoman("Shree");
        woman.DisplayDetails();
    }
}
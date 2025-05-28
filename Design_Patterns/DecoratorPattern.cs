public abstract class Beverage
{
    protected string Description = "Unknown Beverage";
    protected decimal Cost;
    public abstract string getDescription();
    public abstract decimal getCost();
}

public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Espresso";
        Cost = 1.99m;
    }
    public override string getDescription()
    {
        return Description;
    }
    public override decimal getCost()
    {
        return Cost;
    }
}

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        Description = "House Blend Coffee";
        Cost = 0.89m;
    }
    public override string getDescription()
    {
        return Description;
    }
    public override decimal getCost()
    {
        return Cost;
    }
}

public abstract class CondimentDecorator : Beverage
{
    public abstract override string getDescription();
    public abstract override decimal getCost();
}

public class Mocha : CondimentDecorator
{
    Beverage beverage;

    public Mocha(Beverage beverage)
    {
        this.beverage = beverage;
    }
    public override string getDescription()
    {
        return $"{this.beverage.getDescription()}, Mocha";
    }
    public override decimal getCost()
    {
        return this.beverage.getCost() + 1.99M;
    }
}

public class Milk : CondimentDecorator
{
    Beverage beverage;
    public Milk(Beverage beverage)
    {
        this.beverage = beverage;
    }
    public override string getDescription()
    {
        return $"{this.beverage.getDescription()}, Milk";
    }
    public override decimal getCost()
    {
        return this.beverage.getCost() + 2.99M;
    }
}

public class MyClass
{
    public static void Main(string[] args)
    {
        Beverage espresso = new Espresso();
        espresso = new Mocha(new Milk(espresso));
        espresso = new Mocha(espresso);
        System.Console.WriteLine(espresso.getDescription());
        System.Console.WriteLine($"${espresso.getCost()}");

        
        Beverage HouseBlend = new HouseBlend();
        HouseBlend = new Milk(HouseBlend);
        System.Console.WriteLine(HouseBlend.getDescription());
        System.Console.WriteLine($"${HouseBlend.getCost()}");
    }
}
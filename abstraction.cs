abstract class vehicle
{
    public float horsePower;
    vehicle() { }
    public vehicle(float horsePower) { this.horsePower = horsePower; }
    public abstract void accelerate();//Must be overridden
    public abstract void decelerate();//Must be overridden
    public virtual void honk()
    {
        System.Console.WriteLine("honkkkkkk");
    }//Can be overridden
}

class car : vehicle 
{
    public string brand;
    public car(string brand, float horsePower) : base(horsePower) { this.brand = brand; }
    public override void accelerate()
    {
        System.Console.WriteLine("accelerating");
    }
    public override void decelerate()
    {
        System.Console.WriteLine("decelerating");
    }
}


interface animal //Every method MUST be implemented
{
    void walk();
    void run();
    void sound();
}

interface pet
{
    bool isCute();
    bool hasFur();
}

class dog : animal, pet
{
    public void walk()
    {
        System.Console.WriteLine("Walking");
    }
    public void run()
    {
        System.Console.WriteLine("Running");
    }
    public void sound()
    {
        System.Console.WriteLine("Barking");
    }
    public bool isCute()
    {
        return true;
    }
    public bool hasFur()
    {
        return true;
    }
}



public class MyClass
{

    public static void Main(string[] args)
    {
        car c1 = new car("Honda", 100);
        c1.accelerate();
        c1.decelerate();
        c1.honk();



        dog d1 = new dog();
        d1.walk();
        d1.run();
        d1.sound();
    }
}
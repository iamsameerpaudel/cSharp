class human
{
    public string name;
    public string gender;
    public float runningSpeed;
    public float strength;
    public float stamina;
    public float money;

    public human() { }

    public human(string name, string gender, float speed = 10, float strength = 10, float stamina = 10, float money = 10)
    {
        this.name = name;
        this.gender = gender;
        this.runningSpeed = speed;
        this.strength = strength;
        this.stamina = stamina;
        this.money = money;
    }
    public void changeStrength(float strength)
    {
        this.strength = strength;
    }

    public void changeRunningSpeed(float newRunningSpeed)
    {
        this.runningSpeed = newRunningSpeed;
    }
    public void changeStamina(float newStamina)
    {
        this.stamina = newStamina;
    }
    public void changeAmountOfMoney(float money)
    {
        this.money = money;
    }


    public void displayDetails()
    {
        System.Console.WriteLine($"Name = {name}");
        System.Console.WriteLine($"Gender = {gender}");
        System.Console.WriteLine($"Speed = {runningSpeed}");
        System.Console.WriteLine($"Strength = {strength}");
        System.Console.WriteLine($"Stamina = {stamina}");
        System.Console.WriteLine($"Money = ${money}");
    }

}

sealed class npc : human
{
    public string occupation;
    public bool isViolent;
    public npc(string name, string gender, string occupation, bool isViolent, float speed = 10, float strength = 10, float stamina = 10, float money = 10) : base(name, gender,speed,strength,stamina,money)
    {
        this.occupation = occupation;
        this.isViolent = isViolent;
    }
    public void displayNpcDetails()
    {
        base.displayDetails();
        System.Console.WriteLine($"Occupation = {occupation}");
        System.Console.WriteLine($"isViolent = {isViolent}");
    }

}

sealed class player : human
{



}
public class game
{
    public static void Main(string[] args)
    {
        System.Console.Clear();
        // human h1 = new human("Tony Stark", "male", 99, 99, 99, 9999999);
        // h1.displayDetails();
        npc n1 = new npc("Steve","male","Engineer",false,100,100,100,99);
        n1.displayNpcDetails();
    }
}
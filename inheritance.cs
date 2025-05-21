class human
{
    string name;
    string gender;
    float runningSpeed;
    float strength;
    float stamina;
    float money;

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
        System.Console.WriteLine("---------------------------------------------------");
    }

}

sealed class npc : human
{
    string occupation;
    bool isViolent;
    public npc(string name, string gender, string occupation, bool isViolent, float speed = 10, float strength = 10, float stamina = 10, float money = 10) : base(name, gender, speed, strength, stamina, money)
    {
        this.occupation = occupation;
        this.isViolent = isViolent;
    }
    public new void displayDetails()
    {

        base.displayDetails();
        System.Console.WriteLine($"Occupation = {occupation}");
        System.Console.WriteLine($"isViolent = {isViolent}");
        System.Console.WriteLine("---------------------------------------------------");
    }
    public void changeOccupation(string occupation)
    {
        this.occupation = occupation;
    }
    public void changeIsViolent(bool isViolent)
    {
        this.isViolent = isViolent;
    }
}

sealed class player : human
{
    string[] friends = new string[5];
    int noOfKills;

    public player(string[] friends, int noOfKills, string name, string gender, float speed = 10, float strength = 10, float stamina = 10, float money = 10) : base(name, gender, speed, strength, stamina, money)
    {
        this.friends = friends;
        this.noOfKills = noOfKills;
    }
    public new void displayDetails()
    {
        base.displayDetails();
        System.Console.Write($"Friends: ");
        foreach (string friend in friends)
        {
            System.Console.Write($"{friend}, ");
        }
        System.Console.WriteLine("");
        System.Console.WriteLine($"noOfKills = {noOfKills}");
        System.Console.WriteLine("---------------------------------------------------");
    }
    public void setFriends(string[] friends)
    {
        this.friends = friends;

    }
    public void changeNoOfKills(int noOfKills)
    {
        this.noOfKills = noOfKills;
    }
}
public class game
{
    public static void Main(string[] args)
    {
        System.Console.Clear();
        human h1 = new human("Tony Stark", "male", 99, 99, 99, 9999999);
        h1.displayDetails();
        npc n1 = new npc("Steve", "male", "Engineer", false);
        n1.displayDetails();
        player p1 = new player(new string[] { "Tony", "Sameer", "Steve", "Banner", "Parker" }, 100, "Stephen", "male");
        p1.displayDetails();
        // p1.setFriends(new string[] { "Wayne", "Batman", "Wonder Woman", "Superman", "Flash" });
        // p1.changeAmountOfMoney(1000);
        // p1.changeRunningSpeed(121);
        // p1.changeStamina(101);
        // p1.changeStrength(128);
        // p1.changeNoOfKills(289);
        // // p1.displayPlayerDetails();
        // p1.displayDetails();
    }
}
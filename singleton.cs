    public class Singleton
{
    private static Singleton uniqueInstance; //This keeps track if the instance is already created
    private Singleton() { } //This blocks the class from being instantiated with the new keyword
    private int count = 0;

    public static Singleton getInstance() //This is the only way to get the instance 
    {
        if (uniqueInstance == null)
        {
            uniqueInstance = new Singleton();
        }
        return uniqueInstance;
    }
    public void display()
    {
        count++;
        System.Console.WriteLine($"Hii {count}");
    }
}

class Hero
{
    public static void Main(string[] args)
    {
        Singleton s1 = Singleton.getInstance();
        s1.display(); //1
        Singleton s2 = Singleton.getInstance(); //The same instance is being created here
        s2.display(); //2
        Singleton s3 = Singleton.getInstance(); //The same instance is being created here
        s3.display(); //3
        Singleton s4 = Singleton.getInstance(); //The same instance is being created here
        s4.display(); //4
        Singleton s5 = Singleton.getInstance(); //The same instance is being created here
        s5.display(); //5
        Singleton s6 = Singleton.getInstance(); //The same instance is being created here
        s6.display(); //6
    }
}


public sealed class MyClass
{
    private static volatile IMyObject instance;
    private static Object syncRootObject = new Object();

    public static IMyObject Instance
    {
        get
        {
            if (instance == null)
            {
                lock (syncRootObject)
                {
                    if (instance == null)
                    {
                        instance = new MyObject();
                    }
                }
            }
            return instance;
        }
    }
}
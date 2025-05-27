using System;

public interface AppleDevices
{
    void DisplayDetails();
}

public class IPhone : AppleDevices
{
    private string _name;
    private string _processor;
    private int _memory;
    private int _battery;
    private int _storage;
    private int _cameramegapixels;
    public IPhone()
    {
        _name = "Iphone 16";
        _processor = "A18";
        _memory = 16;
        _storage = 512;
        _battery = 4738;
        _cameramegapixels = 50;
    }
    public IPhone(string name, string processor, int memory, int storage, int battery, int cameramegapixels)
    {
        _name = name;
        _processor = processor;
        _memory = memory;
        _storage = storage;
        _battery = battery;
        _cameramegapixels = cameramegapixels;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Processor: {_processor}");
        Console.WriteLine($"Memory: {_memory}");
        Console.WriteLine($"Storage: {_storage}");
        Console.WriteLine($"Battery: {_battery}");
        System.Console.WriteLine("");
    }
}

public class MacBook : AppleDevices
{
    private string _name;
    private string _cpu;
    private int _memory;
    private int _battery;
    private int _storage;
    public MacBook()
    {
        _name = "MacBook";
        _cpu = "M4 Max";
        _memory = 128;
        _battery = 10000;
        _storage = 2;
    }
    public MacBook(string name, string cpu, int memory, int storage, int battery)
    {
        _name = name;
        _cpu = cpu;
        _memory = memory;
        _storage = storage;
        _battery = battery;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Processor: {_cpu}");
        Console.WriteLine($"Memory: {_memory}");
        Console.WriteLine($"Storage: {_storage}");
        Console.WriteLine($"Battery: {_battery}");
        Console.WriteLine("");
    }
}

public class AppleFactory
{
    public AppleDevices CreateDevice(string deviceType, string name,int memory, int storage, int battery,string cpu="", string processor="",int cameramegapixels = 0)
    {
        return deviceType.ToLower() switch
        {
            "iphone" => new IPhone(),
            "macbook" => new MacBook(),
            _ => throw new ArgumentException("Invalid shape type")
        };
    }
}

class Program
{
    static void Main()
    {
        AppleFactory factory = new AppleFactory();
        AppleDevices mb = factory.CreateDevice("macbook","SameerMacBook",64,1024,14000,"M3 MAX");
        mb.DisplayDetails();
        AppleDevices ip = factory.CreateDevice("iphone","Iphone",12,128,5000,processor:"A18",cameramegapixels:50);
        ip.DisplayDetails();
    }
}
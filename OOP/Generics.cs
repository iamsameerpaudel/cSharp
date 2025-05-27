using System;
public class phone<T, F>
{
    public T name;
    private F memory;
    private T cpu;
    public T CPU
    {
        get => cpu;
        set => cpu = value;
    } 
    public F Memory => memory;
    public phone(T name, T CPU)
    {
        this.name = name;
        this.CPU = CPU;
    }
    public void setMemory(F memory)
    {
        this.memory = memory;
    }
}
public class MyClass
{
    public static void Main(string[] args)
    {
        phone<string, int> apple = new phone<string, int>("apple", "A12");
        apple.setMemory(128);
        Console.WriteLine(apple.name);
        Console.WriteLine(apple.CPU);
        Console.WriteLine(apple.Memory);
    }
}
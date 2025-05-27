using System.Collections.Generic;
using System;
public class item
{
    public string itemName;
    public decimal pricePerUnit;
    public int quantity;
}
class Bill //Bill class only to add items and add total
{
    public string Name { get; set; }
    public decimal totalAmount { get; set; }
    public List<item> itemAmountList = new List<item>();
    public List<item> Items { get => itemAmountList; set { itemAmountList = value; } }

    public Bill(string name, List<item> list)
    {
        this.Name = name;
        this.itemAmountList = list;
    }
    public void calculateTotal()
    {
        foreach (var item in itemAmountList)
        {
            this.totalAmount += (decimal)item.quantity * item.pricePerUnit;
        }
    }
}

class generator //generator class to generate bill
{
    public void billGenerator(Bill bill)
    {
        System.Console.Clear();
        
        System.Console.WriteLine($"Customer's name: {bill.Name}");
        System.Console.WriteLine("-------------------------------");
        System.Console.WriteLine("Product   |   Per Unit Cost   |   Quantity    |   Total");
        foreach (var item in bill.Items)
        {
            System.Console.WriteLine($"{item.itemName}  |   {item.pricePerUnit} |   {item.quantity} |   {item.pricePerUnit * (decimal)item.quantity}");
        }
        System.Console.WriteLine($"Total amount is: {bill.totalAmount}");
    }
}

public class MyClass
{
    public static void Main(string[] args)
    {
        var l1 = new List<item>
        {
            new item { itemName = "apple", pricePerUnit = 50, quantity = 15 },
            new item { itemName = "Orange", pricePerUnit = 150, quantity = 20 },
            new item{ itemName="Banana",pricePerUnit=100,quantity=10},
            new item{ itemName="Mango",pricePerUnit=200,quantity=5}
        };
        Bill b1 = new Bill("Sameer", l1);
        b1.calculateTotal();
        generator g = new generator();
        g.billGenerator(b1);
    }
}
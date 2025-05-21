using System.Collections.Generic;
using System;
class bankAccount
{
    public string bankName = "Nabil Bank";
    public string accountHoldersName;
    private string accountHoldersGender;
    private string accountHoldersAddress;
    private string accountHoldersPhone;
    private string accountHoldersEmail;
    private string accountNumber;
    private List<string> statement = new List<string>();
    private decimal balance;
    private string accountAccessPassword;


    private string[] chars = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

    bankAccount() { }
    public bankAccount(string name, string gender, string address, string phone, string email)
    {
        System.Console.Clear();

        this.accountHoldersName = name;
        this.accountHoldersGender = gender;
        this.accountHoldersAddress = address;
        this.accountHoldersPhone = phone;
        this.accountHoldersEmail = email;

        System.Console.WriteLine("--------------------------------");
        this.accountNumber = createaccNumber();
        System.Console.WriteLine($"Your account number is {this.accountNumber}");
        System.Console.WriteLine("Press Enter to continue");
        Console.ReadLine();

        System.Console.WriteLine("--------------------------------");
        System.Console.WriteLine("Press 'y' to manually create a password.");
        string input = Console.ReadLine();
        if (input == "y")
        {
            System.Console.WriteLine("Please enter a 10 character long password");
            this.accountAccessPassword = Console.ReadLine();
        }
        else
        {
            this.accountAccessPassword = createPassword();
        }
        System.Console.WriteLine("--------------------------------");

        System.Console.WriteLine($"Your password is {this.accountAccessPassword}");
        System.Console.WriteLine("--------------------------------");
    }

    public void displayDetails()
    {
        System.Console.WriteLine("--------------------------------");
        System.Console.WriteLine($"Name: {this.accountHoldersName}");
        System.Console.WriteLine($"Gender: {this.accountHoldersGender}");
        System.Console.WriteLine($"Address: {this.accountHoldersAddress}");
        System.Console.WriteLine($"Phone number: {this.accountHoldersPhone}");
        System.Console.WriteLine($"Email: {this.accountHoldersEmail}");
        System.Console.WriteLine($"Account number: {this.accountNumber}");
        System.Console.WriteLine($"Balance: {this.balance}");
        System.Console.WriteLine("--------------------------------");
    }

    public void displayStatement()
    {
        System.Console.WriteLine("STATEMENT");
        System.Console.WriteLine("--------------------------------");
        foreach (string s in statement)
        {
            System.Console.WriteLine(s);
        }
        System.Console.WriteLine("--------------------------------");
    }

    public void depositAmount(decimal amount)
    {
        System.Console.WriteLine("Enter your password: ");
        string input = Console.ReadLine();
        if (input == this.accountAccessPassword)
        {


            this.balance += amount;
            System.Console.WriteLine("--------------------------------");
            statement.Add("Deposit: " + amount);
            System.Console.WriteLine("Deposited amount: " + amount);
            System.Console.WriteLine("Your new balance is " + this.balance);
            System.Console.WriteLine("--------------------------------");
        }
        else
        {
            System.Console.WriteLine("Incorrect Password!!!");
            System.Console.WriteLine("Try again(y/n): ");
            string input2 = Console.ReadLine();
            if (input2 == "y")
            {
                depositAmount(amount);
            }
            else
            {
                System.Environment.Exit(1);
            }
        }
    }
    public void withdrawAmount(decimal amount)
    {
        System.Console.WriteLine("Enter your password: ");
        string input = Console.ReadLine();
        if (input == this.accountAccessPassword)
        {
            if (amount > this.balance)
            {
                System.Console.WriteLine("--------------------------------");
                System.Console.WriteLine("Insufficient balance");
                System.Console.WriteLine("--------------------------------");
            }
            else
            {
                this.balance -= amount;
                System.Console.WriteLine("--------------------------------");
                statement.Add("Withdraw: " + amount);
                System.Console.WriteLine("Withdrawn amount: " + amount);
                System.Console.WriteLine("Your new balance is " + this.balance);
                System.Console.WriteLine("--------------------------------");
            }
        }
        else
        {
            System.Console.WriteLine("Incorrect Password!!!");
            System.Console.WriteLine("Try again(y/n): ");
            string input2 = Console.ReadLine();
            if (input2 == "y")
            {
                withdrawAmount(amount);
            }
            else
            {
                System.Environment.Exit(1);
            }

        }
    }

    private string createaccNumber()
    {
        var rand = new Random();
        string accNo = "";
        for (int i = 0; i < 10; i++)
        {
            accNo += rand.Next(10).ToString();
        }
        return accNo;
    }

    private string createPassword()
    {
        var rand = new Random();
        string pass = "";
        for (int i = 0; i < 10; i++)
        {
            pass += chars[rand.Next(chars.Length)];
        }
        return pass;
    }

}


public class encapsulation
{
    public static void Main(string[] args)
    {
        bankAccount b1 = new bankAccount("Sameer", "Male", "Hetauda", "9999999999", "gmail@gmail.com");
        b1.depositAmount(1000);
        b1.depositAmount(2900);
        b1.depositAmount(80);
        b1.withdrawAmount(700);
        b1.displayStatement();
        b1.displayDetails();
    }
}
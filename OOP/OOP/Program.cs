using System;

namespace OOP;

public class BankAccount
{
    public string name;
    //int accountNum;
    public double balance = 0;
    public double Balance
    {
        get;
        set;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public double Deposit(double AddAmt)
    {
        Balance += AddAmt;
        return balance;
    }

    public double WithDraw(double OutAmt)
    {
        Balance -= OutAmt;
        return balance;
    }


}

class Program
{
    static void Main()
    {
        BankAccount customer1 = new BankAccount();
        // customer name
        Console.Write("Enter your name: ");
        customer1.Name = Console.ReadLine();
        Console.WriteLine("Welcome back, {0}", customer1.Name);

        // random number generator for the balance
        Random random = new Random();
        customer1.Balance = random.Next(500, 1000000);

        // initial balance
        Console.WriteLine("Your balance is: " + customer1.Balance);

        // Deposit
        Console.Write("Amount of Deposit: ");
        double AddAmt = double.Parse(Console.ReadLine());
        customer1.Deposit(AddAmt);
        Console.WriteLine("Your new balance is: " + customer1.Balance);

        // Withdraw
        Console.Write("Amount of Withdraw: ");
        double OutAmt = double.Parse(Console.ReadLine());

        if(OutAmt <= customer1.Balance)
        {
            customer1.WithDraw(OutAmt);
            Console.WriteLine("Your new balance is: " + customer1.Balance);
        }
        else
        {
            Console.WriteLine("INSUFFICENT BALANCE!");
            Console.WriteLine("Your balance still: " + customer1.Balance);
        }

        // exit message
        Console.WriteLine("Have a good day :)");
    }
}



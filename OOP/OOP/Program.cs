using System;

public class Factroial
{
    public int x;

    public Factroial (int num)
    {
        x = num;
    }

    public void FacCalc()
    {
        int result = 1;
        int i = 1;
        while(i <= x)
        {
            result *= i;
            i++;
        }

        Console.WriteLine("The factorial of {0} is {1}", x, result);
        
    }
}


class Program
{
    static void Main()
    {

        Console.Write("Enter the number u want the factorial for: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Factroial factorial = new Factroial(num);
        factorial.FacCalc();
    }
}



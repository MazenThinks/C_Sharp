using System;

public class number
{
    public int x;

    public number (int num)
    {
        x = num;
    }

    public void numba()
    {
        
        for(int i = 1; i <= x; i++)
        {
            Console.WriteLine(i);
        }
        
    }
}


class Program
{
    static void Main()
    {

        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine();

        number factorial = new number(num);
        factorial.numba();
    }
}



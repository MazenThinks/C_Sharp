/* Imagine a publishing company that markets both book and audiocassette versions of its
works. Create a class publication that stores the title (a string) and price (type float) of a
publication. From this class derive two classes: book, which adds a page count (type int),
and tape, which adds a playing time in minutes (type float). Each of these three classes should
have a getdata() function to get its data from the user at the keyboard, and a putdata() function
to display its data. Write a program to test the book and tape classes by creating instances of
them, asking the user to fill in data with getdata(), and then displaying the data with putdata(). */

using System;
using System.Diagnostics;

namespace OOP;

public class publication
{
    public string title;
    public float price;

    public void getdata()
    {
        Console.WriteLine("Enter the title: ");
        title = Console.ReadLine();
        Console.WriteLine("Enter the price: ");
        price = float.Parse(Console.ReadLine());
    }

    public void putdata()
    {
        Console.WriteLine("title: "+ title);
        Console.WriteLine("price: "+ price);
    }
}

public class book : publication
{
    public int PageCount;

    public void getdata()
    {
        base.getdata();
        Console.WriteLine("Enter the Page count: ");
        PageCount = int.Parse(Console.ReadLine());
    }

    public void putdata()
    {
        base.putdata();
        Console.WriteLine("Page count: " + PageCount);
    }
}

public class tape : publication
{
    float PlayingTime;

    public void getdata()
    {
        base.getdata();
        Console.WriteLine("Enter the playing time: ");
        PlayingTime = float.Parse(Console.ReadLine());
    }
    public void putdata()
    {
        base.putdata();
        Console.WriteLine("playing time: " + PlayingTime);
    }
}

class Program
{
    static void Main()
    {
        book b1 = new book();
        tape t1 = new tape();

        b1.getdata();
        t1.getdata();
        Console.WriteLine("Your Data:");
        b1.putdata();
        t1.putdata();

    }
}



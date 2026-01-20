
using System;

class Geeks
{
    private string month;
    private int year;

    // declaring Copy constructor
    public Geeks(Geeks x)
    {
        month = x.month;
        year = x.year;
    }

    // Instance constructor
    public Geeks(string month, int year)
    {
        this.month = month;
        this.year = year;
    }

   
    public static void Main()
    {
        // Create a new Geeks object.
        Geeks g1 = new Geeks("June", 2018);

        // here is g1 details is copied to g2.
        Geeks g2 = new Geeks(g1);

        Console.WriteLine("make a example of Constructor ");
    }
}
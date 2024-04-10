using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");
        Running _running = new Running(DateTime.Now, "Running", 30, 3.0);
        Cycling _cycling = new Cycling(DateTime.Now, "Cycling", 60, 10.0);
        Swimming _swimming = new Swimming(DateTime.Now, "Swimming", 45, 20);
        Console.WriteLine(_running.GetSummary());
        Console.WriteLine(_cycling.GetSummary());
        Console.WriteLine(_swimming.GetSummary());

    }
}
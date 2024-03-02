using System;

class Program
{
    static void Main(string[] args)
    {
    //Console.WriteLine("Hello Prep2 World!");

    Console.Write("What is your grade percentage? ");
    string answer = Console.ReadLine();
    int grade = int.Parse(answer);
    int last_digit = grade % 10;
    string letter = "";
    string modifier = "";

    if (grade >= 90)
    {
        letter = "A";
    }
    else if (grade >= 80)
    {
        letter = "B";
    }
    else if (grade >= 70)
    {
        letter = "C";
    }
    else if (grade >= 60)
    {
        letter = "D";
    }
    else
    {
        letter = "F";
    }

    
    if (grade >= 70)
    {
        Console.WriteLine("Congatulations! You passed!");
    }
    else
    {
        Console.WriteLine("Better luck next time!");
    }

    if (last_digit >= 7)
    {
        modifier = "+";
    }
    else if (last_digit <=3)
    {
        modifier = "-";
    }
    else
    {
        modifier ="";
    }

    if (letter != "F"){
    Console.WriteLine($"Your grade is: {letter}{modifier}");
    }
    else{
    Console.WriteLine($"Your grade is: {letter}");
    }
    }
}
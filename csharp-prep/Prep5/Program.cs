using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string username = PromptUsername();
        int usernum = PromptUsernum();
        int squared_num = SquaredNumber(usernum);
        DisplayResult(username, squared_num);
    }
    static void DisplayWelcomeMessage(){
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUsername(){
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUsernum(){
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquaredNumber(int number){
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square){
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
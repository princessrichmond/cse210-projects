using System;

public class Activity{
    public string _name{
        get;
        set;
    }
    public string _description{
        get;
        set;
    }
    public int _duration{
        get;
        set;
    }

    public Activity(string name, string description, int duration){
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage(){
        Console.WriteLine($"Welcome to the {_name} {_description}.");
        
    }
    public void DisplayEndingMessage(){
        Console.WriteLine($"You have completed another {_duration} seconds of {_name}");
    }
    public void ShowSpinner(int seconds){
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("|");

        foreach (string s in animationStrings){
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void ShowCountDown(int seconds){
        for(int i = 5; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
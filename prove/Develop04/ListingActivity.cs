using System;
public class ListingActivity: Activity{
    private List<string> _prompts = new List<string>();
    private int _count;

    public ListingActivity(): base("Listing Activity.", "\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0){

    }
    public void Run(int duration){
        DisplayStartingMessage();
        Console.WriteLine("Get ready...");

        Console.WriteLine("");
        DisplayEndingMessage();
    }
    public string GetRandomPrompt(){
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
    public List<string> GetListFromUser(){
        List<string> list = new List<string>();
        return list;
    }
}
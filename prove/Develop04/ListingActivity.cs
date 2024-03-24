using System;
public class ListingActivity: Activity{
    private List<string> _prompts = new List<string>();
    private int _count;

    public ListingActivity(): base("Listing Activity.\n", "\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area", 0){
        _prompts.Add("--- When you have felt the Holy Ghost this month? ---");
    }
    public void Run(int duration){
        _count = 0;
         _duration = duration;
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(duration);
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        Console.Write("\n");

        List<(string, DateTime)> responses = GetListFromUser(duration);
        int count = responses.Count;
        Console.WriteLine($"You listed {count} items!");
           
        // DateTime startTime = DateTime.Now;
        // while ((DateTime.Now - startTime).TotalSeconds < duration){
        //     Console.Write("> ");
        //     string response = Console.ReadLine();
        // }
        
        Console.WriteLine("\nWell done!!\n");
        DisplayEndingMessage();
        ShowSpinner(duration);
        Console.Clear();
    }
    public string GetRandomPrompt(){
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
    public List<(string, DateTime)> GetListFromUser(int duration){
        DateTime startTime = DateTime.Now;
        List<(string, DateTime)> list = new List<(string, DateTime)>();
        while((DateTime.Now - startTime).TotalSeconds < duration){
            Console.Write("> ");
            string response = Console.ReadLine();
            if(response != null && response.Trim() != ""){
                list.Add((response, DateTime.Now));
                _count++;
            }
        }
        return list;
    }
}
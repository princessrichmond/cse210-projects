using System;
public class RefectingActivity: Activity{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public RefectingActivity(): base("Reflecting Activity.\n", "\nThis activity will help you reflect on times in your life when you have shown and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0){

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
    public string GetRandomQuestion(){
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }
    public void DisplayPrompt(){
        Console.WriteLine(GetRandomPrompt());
    }
    public  void DisplayQuestions(){
        foreach (var question in _questions){
            Console.WriteLine(question);
        }
    }


}
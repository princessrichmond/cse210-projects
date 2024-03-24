using System;
public class RefectingActivity: Activity{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public RefectingActivity(): base("Reflecting Activity.\n", "\nThis activity will help you reflect on times in your life when you have shown and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", 0){
        _prompts.Add("\n--Think of a time when you did something really difficult. ---");
        _questions.Add("\nHow did you feel when it was complete?");
        _questions.Add("\nWhat was your favorite thing about this experience?");
        _questions.Add("\nIn what ways do you think you need to improve?");
        _questions.Add("\nWhat does that that tell you about yourself and how you learn?");
    }
    public void Run(int duration){
        // DisplayStartingMessage();

        _duration = duration;
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(duration);
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        while(Console.ReadKey().Key != ConsoleKey.Enter){}

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(3);

        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration){
            Console.Clear();
            while(_questions.Count > 0){
                var randomQuestionIndex = new Random().Next(_questions.Count);
                var question = _questions[randomQuestionIndex];
                Console.Write(question);
                _questions.RemoveAt(randomQuestionIndex);
                ShowSpinner(duration);

            }
        }
        // for (int i=5; i>0; i--){
        //     Console.Write(i);
        //     Thread.Sleep(1000);
        // }
        //note from the lesson: future enhancement, make sure no duplicates questions until you got through them all
       
        // Console.Write(GetRandomQuestion());
        // ShowSpinner(duration);
        // Console.Write(GetRandomQuestion());
        // ShowSpinner(duration);

        // int countdownDuration = duration >= 10? 5: 3;
        // ShowSpinner(duration);
        // DateTime startTime = DateTime.Now;
        // while ((DateTime.Now - startTime).TotalSeconds < duration){
        //     Thread.Sleep(1000);
            

        // }
        Console.WriteLine("\nWell done!!");
        DisplayEndingMessage();
        ShowSpinner(duration);
        Console.Clear();
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

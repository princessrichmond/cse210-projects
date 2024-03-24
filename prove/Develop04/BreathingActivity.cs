using System;
public class BreathingActivity: Activity{
    public BreathingActivity(): base("Breathing Activity.\n","\nThis activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.", 0){
        
    }
    public void Run(int duration){
        _duration = duration;
        Console.Clear();
        Console.WriteLine("Get ready...");
        int countdownDuration = duration >= 10? 5: 3;
        ShowSpinner(duration);
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration){
            Thread.Sleep(1000);
            Console.Write("\nBreathe in...");
            ShowCountDown(3);
            Console.Write("\nNow breathe out...");
            ShowCountDown(3);
            Console.WriteLine("");

        }
        Console.WriteLine("\nWell done!!\n");
        DisplayEndingMessage();
        ShowSpinner(duration);

        Console.Clear();

}
}
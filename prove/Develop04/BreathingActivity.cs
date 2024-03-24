using System;
public class BreathingActivity: Activity{
    public BreathingActivity(): base("Breathing Activity.\n","\nThis activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.", 0){
        
    }
    public void Run(int duration){
        // DisplayStartingMessage();
        // Console.WriteLine("This activity will help you relax by walking through breathing in and out slowly.");
        // Console.WriteLine("Clear your mind and focus on your breathing.");
        // ShowCountDown(3);
        Console.Clear();
        Console.WriteLine("Get ready...");
        int countdownDuration = duration >= 10? 5: 3;
        // ShowCountDown(countdownDuration);
        // Console.WriteLine("Get ready...");
        ShowSpinner(duration);
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration){
            // ShowSpinner(duration);
            Thread.Sleep(1000);
            Console.Write("\nBreathe in...");
            ShowCountDown(3);
            Console.Write("\nNow breathe out...");
            ShowCountDown(3);
            Console.WriteLine("");

        }
        // for(int i = 0; i<duration; i++){
            // Console.WriteLine("/");
            // Thread.Sleep(1000);
            // Console.WriteLine("Breathe in...");
            // ShowCountDown(3);
            // Console.WriteLine("Now breathe out...");
            // ShowCountDown(3);
        
        Console.WriteLine("\nWell done!!\n");
        DisplayEndingMessage();
        ShowSpinner(duration);

        Console.Clear();

}
}
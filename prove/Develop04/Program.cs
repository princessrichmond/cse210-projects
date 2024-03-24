using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        while (!quit){
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice;
            if(!int.TryParse(Console.ReadLine(), out choice)){
                Console.WriteLine("Invalid input. Please enter a number from 1 to 4");
                continue;
            }
            if(choice == 1){
                StartBreathingActivity();
            }
            else if(choice == 2){
                StartReflectingActivity();

            }
            else if(choice == 3){
                StartListingActivity();

            }
            else if (choice == 4){
                quit = true;
            }
            else{
                Console.WriteLine("Invalid choice. Please select a number from 1 to 4");
            }
        }
    }

    static void StartBreathingActivity(){
        Console.Clear();
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.DisplayStartingMessage();
        // Console.WriteLine("Get ready...");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        breathingActivity.Run(duration);
        


    }
    static void StartReflectingActivity(){
        Console.Clear();
        RefectingActivity reflectingActivity = new RefectingActivity();
        reflectingActivity.DisplayStartingMessage();
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        reflectingActivity.Run(duration);
    }

    static void StartListingActivity(){
        Console.Clear();
        ListingActivity listingActivity = new ListingActivity();
        listingActivity.DisplayStartingMessage();
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        listingActivity.Run(duration);
    }
        // Console.WriteLine("Hello Develop04 World!");
        // BreathingActivity breathingActivity = new BreathingActivity();
        // breathingActivity.Run();

        // ListingActivity listingActivity = new ListingActivity();
        // listingActivity.Run();

        // RefectingActivity reflectingActivity = new RefectingActivity();
        // reflectingActivity.Run();
    
}
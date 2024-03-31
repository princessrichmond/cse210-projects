using System;

class Program
{
    static GoalManager goalManager = new GoalManager();
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        Console.WriteLine("You have 0 points");
        DisplayMenu();
    }
    static void DisplayMenu(){
        bool quit = false;
        while (!quit){
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1"){
                CreateGoal();
            }
            else if (choice == "2"){
                ListGoals();
            }
            else if (choice == "3"){
                SaveGoals();
            }
            else if (choice == "4"){
                LoadGoals();
            }
            else if (choice == "5"){
                RecordEvent();
            }
            else if (choice == "6"){
                quit = true;
            }
            else{
                Console.WriteLine("Invalid choice. Please try again.");
                DisplayMenu();
            }
    }
    }
}
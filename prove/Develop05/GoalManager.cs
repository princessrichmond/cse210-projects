using System;
using System.IO;
using System.Collections.Generic;
// using System.IO.StreamWriter;
// using System.IO.StreamReader;

public class GoalManager{
    public List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(){
        // _goals = new List<Goal>();
        _score = 0;
    }
    public void Start(){
        int choice;
        do{
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            if (int.TryParse(Console.ReadLine(), out choice)){
                switch (choice){
                    case 1:
                        CreateGoal();
                        break;
                    case 2:
                        ListGoals();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        RecordEvent();
                        break;
                    case 6: 
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
            else{
                Console.WriteLine("Invalid input. Please enter a number from 1 to 6");
            }
        }
        while (choice != 6);
    }

    private void CreateGoal(){
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What type of goal would you like to create? ");
        if (int.TryParse(Console.ReadLine(), out int typeChoice)){
            switch (typeChoice){
                case 1:
                    CreateSimpleGoal();
                    break;
                case 2:
                    CreateEternalGoal();
                    break;
                case 3:
                    CreateChecklistGoal();
                    break;
                default:
                    Console.WriteLine("Invalid goal type. Please try again.");
                    break;
            }
        }
        else{
            Console.WriteLine("Invalid input. Please enter a number from 1 to 3.");
        }
    }
    
    private void CreateEternalGoal(){
        Console.Write("What is the name of your Goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal ");
        if (int.TryParse(Console.ReadLine(), out int points)){
            _goals.Add(new EternalGoal(name, description, points.ToString()));
        }
        else{
            Console.WriteLine("Invalid input. Points must be a number.");
        }
    }

        // Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        // int target = int.Parse(Console.ReadLine());
        // Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        // int bonus = int.Parse(Console.ReadLine());

    private void CreateSimpleGoal() {
        Console.Write("What is the name of your Goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        if (int.TryParse(Console.ReadLine(), out int points)) {
            _goals.Add(new SimpleGoal(name, description, points.ToString()));
            Console.WriteLine("Goal created successfully.");
        }
        else {
            Console.WriteLine("Invalid input. Points must be a number.");
        }
    }

    private void CreateChecklistGoal(){
        Console.Write("What is the name of your Goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        if (int.TryParse(Console.ReadLine(), out int points)){
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            if (int.TryParse(Console.ReadLine(), out int target)){
                Console.Write("What is the bonus for accomplishing it that many times? ");
                if (int.TryParse(Console.ReadLine(), out int bonus)){
                    _goals.Add(new ChecklistGoal(name, description, points.ToString(), target, bonus));
                    Console.WriteLine("Goal created successfully.");
                }
                else{
                    Console.WriteLine("Invalid input.Target must be a number.");
                }
            }
        }
        else{
            Console.WriteLine("Invalide input. Points must be a number.");
        }       
    }

    private void ListGoals(){
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++){
            Console.WriteLine($"{i + 1}. [{(_goals[i].IsComplete() ? 'X' : ' ')}] {_goals[i].GetDetailsString()}");
        }
    }

    private void SaveGoals(){
       Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename)) {
            foreach (var goal in _goals) {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals are saved successfully.");
    }


    private void LoadGoals() {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        _goals.Clear();
        try {
            using (StreamReader reader = new StreamReader(filename)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    // Parse and add goals
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        catch (IOException e) {
            Console.WriteLine($"Error reading the file: {e.Message}");
        }
    }
   
    private void RecordEvent(){
        int choice= 0;
        if(_goals.Count == 0){
            Console.WriteLine("There are no goals to record events for.");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++){
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Which goal you accomplish? Enter the number: ");
        // if(int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= _goals.Count){
        //     _goals[choice - 1]. RecordEvent();
        //     int pointsEarned = _goals[choice - 1]._points;
        //     _score += pointsEarned;
        if (int.TryParse(_goals[choice - 1].Points, out int pointsEarned)) {
            _score += pointsEarned;
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        else{
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
        }
    }
}
    
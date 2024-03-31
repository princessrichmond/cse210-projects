using System;
using System.IO;
// using System.IO.StreamWriter;
// using System.IO.StreamReader;

public class GoalManager{
    public List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start(){
        Console.WriteLine("");
    }
    public void DisplayPlayerInfo(){
        Console.WriteLine($"You have {_score} points");
    }
    public void ListGoalNames(){
        for(int i=0; i < _goals.Count; i++){
            Console.WriteLine($"{i+1}, {_goals[i]._shortName}");
        }
    }
    public void ListGoalDetails(){
        foreach (var goal in Goals)
        {
            Console.WriteLine(goal.GetDeatailsString());
        }
    }
    public void CreateGoal(){
        // What is the name of your Goal?
        // What is a short description of it?
        // What is the amount of points associated with this goal? 
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("What type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        if (goalType == 1){
            Console.Write("What is the name of your Goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal ");
            int points = int.Parse(Console.ReadLine());

            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalType == 2){
            Console.Write("What is the name of your Goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal ");
            int points = int.Parse(Console.ReadLine());

            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalType == 3){
            Console.Write("What is the name of your Goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal ");
            int points = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else{
            Console.WriteLine("Invalid goal type. Please try again.");
            CreateGoal();
        }
        
        DisplayMenu();
        // Console.WriteLine("Select a choice from the menu:")

    }
    public void RecordEvent(){
        // The goals are:
        // Congratulations! You have earned 100 points!
        // You now have 150 points
        Console.WriteLine("\nThe goals are: ");
        for (int i = 0; i < goals.Count; i++){
            Console.WriteLine($"{i + 1}. {goals[i].shortname} ({_goals[i].description})");
        }
        Console.Write("\nWhich goal you accomplish? ");
        int goalNum = int.Parse(Console.ReadLine());

        if (goalNum > 0 && goalNum <= goals.Count){
            Goal completedGoal = _goals[goalNum - 1];
            if(!completedGoal.IsComplete()){
                completedGoal.RecordEvent();
                _score += completedGoal.points;
                Console.WriteLine($"Congratulations! You have earned {completedGoal.points} points!");
            }
            else{
                Console.WriteLine("This goal has already been completed.");
            }
            
        }
        else{
            Console.WriteLine("Invalid goal selection.");
        }
        Console.WriteLine("You now have {_score} points.");
        DisplayMenu();
    }



    public void SaveGoals(){
        // What is the filename for the goal file? 
        Console.WriteLine("What is the filename for the goal file?  ");
        string filename = Console.ReadLine();

        try{
            using (StreamWriter writer = new StreamWriter(filename)){
                foreach (Goal goal in _goals){
                    string goalString = goal.GetStringRepresentation();
                    writer.WriteLine(goalString);
                }
                Console.WriteLine("Goals saved successfully.");
            }
        }
        catch (Exception ex){
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
        DisplayMenu();
    }
    public void LoadGoals(){
        //What is the filename for the goal file? 
         Console.WriteLine("What is the filename for the goal file?  ");
        string filename = Console.ReadLine();

        try{
            using (StreamReader writer = new StreamReader(filename)){
                string line;
                while ((line = reader.ReadLine()) != null){
                    Goal goal = goal.CreateGoalFromString(line);
                    if (goal != null){
                        _goals.Add(goal);
                    }
                }
                Console.WriteLine("Goals loaded successfully.");
            }
        }
        catch (Exception ex){
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
        DisplayMenu();
    }
        

}

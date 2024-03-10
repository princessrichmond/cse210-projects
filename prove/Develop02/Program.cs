using System;
using System.Collection.Generic;
// System.IO.StreamWriter
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true){
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
        
            switch (choice){
                case "1":
                    Console.Write("Enter your prompt: ");
                    string prompt = Console.ReadLine();
                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    journal.LoadFromFile("journal.txt");
                    break;
                case "4":
                    journal.SaveToFile("journal.txt");
                    break;
                case "5":
                    Console.WriteLine("Thank you, bye!");
                    return;
                default: 
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}




public class Journal{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string response){
        Entry newEntry = new Entry { _promptText = prompt, entryText = response};
        this._entries.Add(newEntry);
    }
    
    public void DisplayAll(){
        foreach (Entry entry in this._entries){
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"Response: {entry.EntryText}\n");
        }
    }

    public void SaveToFile(string filename){
        Console.WriteLine("Entries saved to file: "+filename);
    }

    public void LoadFromFile(string filename){
        Console.WriteLine("Entries loaded from file: "+filename);
    }
}




public class Entry{
    public string _date;
    public string entryText;
    public string _promptText;

    public void Display(){
        Console.WriteLine($"Date:{_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry Text: {entryText}\n");
    }
}





public class PromptGenerator{
    private List<string> _prompts = new List<string>{
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt(){
        Random random = new Random();
        int ran = random.Next(_prompts.Count);
        return _prompts[ran];
    }
}
using System; 
using System.Collections.Generic; 
using System.IO;

class Program { 
    static void Main(string[] args) { 
        Journal journal = new Journal(); 
        PromptGenerator promptGenerator = new PromptGenerator(); 
        // journal.LoadFromFile("journal.txt");

        while (true) { 
            Console.WriteLine("Please select one of the following choices:"); 
            Console.WriteLine("1. Write"); 
            Console.WriteLine("2. Display"); 
            Console.WriteLine("3. Load"); 
            Console.WriteLine("4. Save"); 
            Console.WriteLine("5. Quit"); 

            Console.Write("What would you like to do? "); 
            string choice = Console.ReadLine(); 

        switch (choice) { 
            case "1": 
                journal.AddEntry();
                // string randomPrompt = promptGenerator.GetRandomPrompt();
                // Console.WriteLine($"{randomPrompt}"); 
                // Console.Write("Enter your response: "); 
                // string response = Console.ReadLine(); 
                // journal.AddEntry(randomPrompt, response); 
                break; 
            case "2": 
                journal.DisplayAll(); 
                break; 
            case "3": 
                // string filename = Console.ReadLine();
                Console.Write("Enter the file name: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file); 
                break; 
            case "4": 
                Console.Write("Enter the file name: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                break; 
            case "5": 
                Console.WriteLine("Thank you, bye!"); 
                return; 
            default: Console.WriteLine("Invalid choice. Please try again."); 
                break; 
        } } } 


} 
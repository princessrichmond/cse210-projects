using System;

public class Journal { 
    public List<Entry> _entries = new List<Entry>(); 
    PromptGenerator promptGen = new PromptGenerator();
    
    public void AddEntry() { 
        Entry newEntry = new Entry(); 
        // this._entries.Add(newEntry); 
        newEntry._date = DateTime.Now.ToShortDateString();
        newEntry._promptText = promptGen.GetRandomPrompt();
        Console.WriteLine(newEntry._promptText);
        // Console.Write("Enter your response: "); //new add
        newEntry._entryText = Console.ReadLine();
        _entries.Add(newEntry);
        } 
        
    public void DisplayAll() { 
        foreach (Entry entry in _entries) { 
            Console.WriteLine($"Date: {DateTime.Now.ToString("MM/dd/yyyy")} - Prompt: {entry._promptText}");
            Console.WriteLine($"Response: {entry._entryText}\n"); } } 
            
    public void SaveToFile(string filename) { 
        using (StreamWriter writer = new StreamWriter(filename)){
            foreach (Entry entry in _entries){
                writer.WriteLine($"Date: {entry._date};Prompt: {entry._promptText}; Response: {entry._entryText}");
            }
        }
        Console.WriteLine("Entries saved to file: " +filename);
}
    public void LoadFromFile(string filename) { 
        _entries.Clear();
        try{

        
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] loadParts = line.Split(";");
                    if (loadParts.Length >= 3){
                    Entry entry = new Entry();
                    entry._date = loadParts[0];
                    entry._promptText = loadParts[1];
                    entry._entryText = loadParts[2];
                    _entries.Add(entry);
                    }
                    else{
                        Console.WriteLine("Invalid format in the loaded line: " +line);
                    }
                }
            }
            Console.WriteLine("Entries loaded from file: " + filename); 
    } 
        catch (Exception ex){
            Console.WriteLine("An Error occured while loading the file: "+ex.Message);
        }
    }
} 

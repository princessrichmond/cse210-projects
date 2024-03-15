using System;

public class Entry { 
    public string _date; 
    public string _entryText; 
    public string _promptText; 

    public void Display() { 
        Console.WriteLine($"Date:{_date} Prompt: {_promptText}"); 
        Console.WriteLine($"Entry Text: {_entryText}\n"); 
    } 
} 
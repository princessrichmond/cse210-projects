using System;

class Program
{
    static void Main(string[] args)
    {
        // string book = "Proverbs";
        // int chapter = 3;
        // int verse = 5;
        // int endVerse = 6;
        string scriptureText = "Trust in the Lord with all thine heard, and lean not unto thine own understanding; In all thy ways acknowlege him, and he shall direct thy paths straight.";

        Console.WriteLine("Press enter to continue or type 'q' to exit.");
        Console.WriteLine("Proverbs 3: 5-6");

        List<int> hiddenIndices = new List<int>();
        Random random = new Random();
        string[] words = scriptureText.Split(' ');

        foreach(string word in words){
            Console.Write(word + " ");
        }
        while(true){
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Enter){
                if (hiddenIndices.Count < words.Length){
                    int index = random.Next(0, words.Length);
                    while (hiddenIndices.Contains(index)){
                        index = random.Next(0, words.Length);
                    }
            
                    string hiddenWord = words[index];
                    words[index] = new string('_', hiddenWord.Length);
                    hiddenIndices.Add(index);

                    Console.SetCursorPosition(GetCursorPosition(words, index), Console.CursorTop);
                    Console.Write(new string('_', hiddenWord.Length).PadRight(hiddenWord.Length + 1));
                }
                
                else{
                    Console.WriteLine("\nAll words hidden. Press 'q' to exit.");
                }
            }
            else if(keyInfo.KeyChar == 'q' || keyInfo.KeyChar == 'Q'){
                Console.WriteLine("\nEnding program...");
                break;
            }
        }
    }
    static int GetCursorPosition(string[] words, int index){
        int col = 0;
        for (int i = 0; i < index; i++){
            col += words[i].Length + 1;
        }
        return col;
    }
}

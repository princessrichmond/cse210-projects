using System;
//exceeding requirements
class Program
{
    static void Main(string[] args)
    {
        // string book = "Proverbs";
        // int chapter = 3;
        // int verse = 5;
        // int endVerse = 6;
        // string scriptureText = "Trust in the Lord with all thine heard, and lean not unto thine own understanding; In all thy ways acknowlege him, and he shall direct thy paths straight.";
        Console.WriteLine("Scripture Verses:");
        Console.WriteLine("1. Proverbs 3:5-6");
        Console.WriteLine("2. John 13:34-35");
        Console.WriteLine("3. John 3:16");
        Console.WriteLine("4. Matthew 22:37-38");
        Console.WriteLine("5. Psalm 116:1-2");

        Console.Write("\nEnter the number of the Scripture verse you want to display: ");
        int selectedNum;

        while (!int.TryParse(Console.ReadLine(), out selectedNum) || selectedNum < 1 || selectedNum > 5){
            Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
            Console.Write("Enter the number of the scripture verse you want to display: ");
        }

        string selectedVerse = "";
        if (selectedNum == 1){
            selectedVerse = "Proverbs 3:5-6 |Trust in the Lord with all thine heard, and lean not unto thine own understanding; In all thy ways acknowlege him, and he shall direct thy paths straight.";
        }
        else if (selectedNum == 2){
            selectedVerse = "John 13:34-35 |I give you a new commandment: love one another. As I have loved you, so you also should love one another. This is how all will know that you are my disciples, if you have love for one another.";
        }
        else if (selectedNum == 3){
            selectedVerse = "John 3:16 |For God so loved the world that He gave His one and only Son, that whoever believes in Him shall not perish but have eternal life.";
        }
        else if (selectedNum == 4){
            selectedVerse = "Matthew 22:37-38 |Jesus said unto him, Thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind. This is the first and great commandment.";
        }
        else if (selectedNum == 5){
            selectedVerse = "Psalm 116:1-2 |I love the Lord, because he hath heard my voice and my supplications. Because he hath inclined his ear unto me, therefore will I call upon him as long as I live.";
        }
        DisplayScripture(selectedVerse);
    }

    static void DisplayScripture(string verse){
        // Console.WriteLine($"\n{verse}");
        Console.WriteLine("\nPress enter to continue or type 'q' to exit.");
        // Console.WriteLine($"{verse}");
        // Console.WriteLine("Proverbs 3: 5-6");
        string[] parts = verse.Split("|");
        string bookName = parts[0];
        string verseText = string.Join(" ", parts, 1, parts.Length - 1);
        Console.WriteLine(bookName);
        // Console.WriteLine(verseText);

        List<int> hiddenIndices = new List<int>();
        Random random = new Random();
        string[] words = verseText.Split(' ');

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


//requirements
// class Program
// {
//     static void Main(string[] args)
//     {
//         // string book = "Proverbs";
//         // int chapter = 3;
//         // int verse = 5;
//         // int endVerse = 6;
//         string scriptureText = "Trust in the Lord with all thine heard, and lean not unto thine own understanding; In all thy ways acknowlege him, and he shall direct thy paths straight.";

//         Console.WriteLine("Press enter to continue or type 'q' to exit.");
//         Console.WriteLine("Proverbs 3: 5-6");

//         List<int> hiddenIndices = new List<int>();
//         Random random = new Random();
//         string[] words = scriptureText.Split(' ');

//         foreach(string word in words){
//             Console.Write(word + " ");
//         }
//         while(true){
//             ConsoleKeyInfo keyInfo = Console.ReadKey();
//             if (keyInfo.Key == ConsoleKey.Enter){
//                 if (hiddenIndices.Count < words.Length){
//                     int index = random.Next(0, words.Length);
//                     while (hiddenIndices.Contains(index)){
//                         index = random.Next(0, words.Length);
//                     }
            
//                     string hiddenWord = words[index];
//                     words[index] = new string('_', hiddenWord.Length);
//                     hiddenIndices.Add(index);

//                     Console.SetCursorPosition(GetCursorPosition(words, index), Console.CursorTop);
//                     Console.Write(new string('_', hiddenWord.Length).PadRight(hiddenWord.Length + 1));
//                 }
                
//                 else{
//                     Console.WriteLine("\nAll words hidden. Press 'q' to exit.");
//                 }
//             }
//             else if(keyInfo.KeyChar == 'q' || keyInfo.KeyChar == 'Q'){
//                 Console.WriteLine("\nEnding program...");
//                 break;
//             }
//         }
//     }
//     static int GetCursorPosition(string[] words, int index){
//         int col = 0;
//         for (int i = 0; i < index; i++){
//             col += words[i].Length + 1;
//         }
//         return col;
//     }
// }

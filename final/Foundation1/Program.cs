using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        Console.Clear();
        Console.WriteLine("Abstraction with YouTube Videos");
        List<Video> _videos = new List<Video>{
            new Video("Kapuso Mo, Jessica Soho: Mangan Tamu sa Pampanga!", "GMA Public Affairs", 948),
            new Video("KMJS: The Filipino's love affair with grilled food", "GMA Integrated News", 491),
            new Video("Teardrops On My Guitar", "Taylor Swift", 217)
        };
        _videos[0].AddComment(new Comment("Leomar Lozano", "Proud to be Kapampangan<3"));
        _videos[0].AddComment(new Comment("Jeth Baldona", "Basta kapampangan manyaman."));
        _videos[0].AddComment(new Comment("Rhyzen", "Proud to say that I was born in the Culinary Capital of the Philippines 🇵🇭 Tara mangan tamu keni keng pampanga."));
        _videos[1].AddComment(new Comment("Innaday", "Yummy."));
        _videos[1].AddComment(new Comment("Simplytinne", "When you go unli restaurants, opt for more or most expensive items... Your money is worth it."));
        _videos[1].AddComment(new Comment("Josh Taylor", "Wooooowww..."));
        _videos[2].AddComment(new Comment("Tulydas", "I can proudly say that this song is my favourite from her debut."));
        _videos[2].AddComment(new Comment("Jessica Mcgee", "Taylor was flawlessly beautiful in this MV."));
        _videos[2].AddComment(new Comment("Andrea Whitt", "you have the best voice taylor"));

        foreach (var video in _videos){
            Console.WriteLine($"\nTitle: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthSeconds} seconds");
            Console.WriteLine($"No. of Comments: {video.GetNumberOfComments()}");
            int commentNum = 1;
            foreach(var comment in video._comments){
                Console.WriteLine($"    {commentNum}. {comment._name}: {comment._text}");
                commentNum++;
            }
        }
        
    }
}
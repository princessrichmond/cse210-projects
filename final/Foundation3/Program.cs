using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");
        Console.Clear();
        Address _address1 = new Address("1112 Beach Drive", "Manila", "Indiana", "46150");
        Lecture _lecture = new Lecture("Communicating in Marriage", "Preventing Divorce", DateTime.Now, TimeSpan.FromHours(2), _address1, "", 50);

        Address _address2 = new Address("817 Real Happiness Drive", "Joyville", "Indiana", "46061");
        Reception _reception = new Reception("Richmond Wedding", "Richmond Reception", DateTime.Now.AddDays(7), TimeSpan.FromHours(3),_address2, "");

        Address _address3 = new Address("326 Mabuhay Ave", "Shackletown", "Concepcion", "46062");
        OutdoorGathering _outdoor = new OutdoorGathering("Richmond Reunion", "Richmond Gathering", DateTime.Now.AddDays(14), TimeSpan.FromHours(4), _address3, "");
        
        Console.WriteLine("Standard Details: ");
        Console.WriteLine($"\n{_lecture.StandardDetails()}");
        Console.WriteLine(_reception.StandardDetails());
        Console.WriteLine(_outdoor.StandardDetails());

        Console.WriteLine("\nFull Details: ");
        Console.WriteLine(_lecture.FullDetails());
        Console.WriteLine(_reception.FullDetails());
        Console.WriteLine(_outdoor.FullDetails());

        Console.WriteLine("\nShort Description: ");
        Console.WriteLine(_lecture.ShortDescription());
        Console.WriteLine(_reception.ShortDescription());
        Console.WriteLine(_outdoor.ShortDescription());
        
    }
}
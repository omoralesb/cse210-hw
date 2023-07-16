using System;

class Program
{
    static void Main(string[] args)
    { 
        Console.Clear();
        Address address1 = new Address("123 Main St", "Rocklin", "CA", "95677");
        Address address2 = new Address("456 Oak St", "Roseville", "CA", "95747");
        Address address3 = new Address("789 Maple St", "Lincoln", "CA", "95648");

        Lecture lecture = new Lecture("Intro to C#", "Learn the basics of C#", new DateTime(2023, 3, 15), new TimeSpan(10, 0, 0), address1, "John Doe", 50);
        Reception reception = new Reception("Networking Event", "Meet and greet with local professionals", new DateTime(2023, 3, 20), new TimeSpan(18, 0, 0), address2, "rsvp@coolestguyever.com");
        OutdoorGathering gathering = new OutdoorGathering("Picnic in the Park", "Bring your own food and games", new DateTime(2023, 3, 25), new TimeSpan(12, 0, 0), address3, "Sunny skies with a high of 75 degrees");

        Console.WriteLine("Lecture:");
        Console.WriteLine("[STANDARD]:\n" + lecture.GetStandardDetails());
        Console.WriteLine("[FULL]:\n" + lecture.GetEventDetails());
        Console.WriteLine("[SHORT]:\n" + lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception:");
        Console.WriteLine("[STANDARD]:\n" + reception.GetStandardDetails());
        Console.WriteLine("[FULL]:\n" + reception.GetEventDetails());
        Console.WriteLine("[SHORT]:\n" + reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine("[STANDARD]:\n" + gathering.GetStandardDetails());
        Console.WriteLine("[FULL]:\n" + gathering.GetEventDetails());
        Console.WriteLine("[SHORT]:\n" + gathering.GetShortDescription());
        Console.WriteLine();
    }
}
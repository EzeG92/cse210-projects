using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main Street","Springfield","Illinois","USA");
        Address address2 = new Address("101 First Street","Sydney","New South Wales","Australia");
        Address address3 = new Address("456 Elm Avenue","Vancouver","British Columbia","Canada");

        Lecture lecture = new Lecture("The Future of Artificial Intelligence: Opportunities and Challenges.", "Join us for an insightful lecture on AI's transformative potential, ethical considerations, and future challenges.", "June 15, 2024", "10:00 AM - 12:00 PM", address1, "Dr. Emily Chen", 150);

        Console.WriteLine(lecture.GetStandarDetails());
        Console.WriteLine("--------------------");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("--------------------");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("--------------------");

        Reception reception = new Reception ("Business Connections: A Corporate Networking Evening","Join us for an exclusive evening of networking at 'Business Connections: A Corporate Networking Evening.' This event provides a unique opportunity to connect with industry leaders, entrepreneurs, and professionals from various sectors. Enjoy a relaxed atmosphere with drinks and appetizers while expanding your professional network and discovering new business opportunities.","July 22, 2024","6:00 PM to 9:00 PM",address2,"rsvp@businessconnections.com");

        Console.WriteLine(reception.GetStandarDetails());
        Console.WriteLine("--------------------");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("--------------------");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("--------------------");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Outdoor Music Festival","Experience the vibrant energy of live music at 'Summer Beats: Outdoor Music Festival.' Join us for an unforgettable day filled with performances from local bands and artists across various genres. Enjoy food trucks, craft stalls, and a lively atmosphere. This family-friendly event is perfect for music lovers of all ages. Don't miss out on this celebration of community and music.","June 28, 2024","1:00 PM to 9:00 PM",address3,"Please note that this event is weather-dependent. In case of inclement weather, updates will be sent via email.");

        Console.WriteLine(outdoorGathering.GetStandarDetails());
        Console.WriteLine("--------------------");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine("--------------------");
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine("--------------------");
    }
}
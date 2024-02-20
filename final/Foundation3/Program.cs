using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Rainbow Route", "Green Greens", "Cookie Country", "Dreamland");
        LectureEvent lectureEvent = new LectureEvent("Poyo", "Poyo poyo poyo poyo", "May 25, 2024", "5:00 pm", address1, "Kirby", 400);
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(lectureEvent.GetShortDescription());

        Console.WriteLine();

        Address address2 = new Address("Sideways Street", "Flipflop", "Etats", "Antartica");
        List<string> attendees = new List<string>()
        {
            "icebear@snow.com",
            "emporor@penguino.com",
            "sealtheseel@sea.com"
        };
        ReceptionEvent receptionEvent = new ReceptionEvent("Out of Ice", "Discover what is beyond the ice", "Dec 13, 2024", "2:00 pm", address2, attendees);
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());

        Console.WriteLine();

        Address address3 = new Address("Street", "City", "State", "Country");
        OutdoorGatheringEvent outdoorEvent = new OutdoorGatheringEvent("Better Names", "How to give our community a better name", "August 7, 2024", "7:30 pm", address3);
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}
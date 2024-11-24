using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        Address lectureAddress = new Address("281 W Lane Ave", "Columbus", "OH");
        LectureEvent lecture = new LectureEvent("The World Today", "A night of learning with Dr. Fuller about today's news!", "4/18/2025", "7:00 PM", lectureAddress, "Dr. Fuller", 350); 

        Address receptionAddress = new Address("358 W 250 E", "Idaho Falls", "ID");
        ReceptionEvent reception = new ReceptionEvent("Mr. and Mrs.", "Join us for the marriage of Ti Smack and Faith Schnepf!", "12/30/24", "5:00 PM", receptionAddress, "smackwedding@gmail.com");

        Address outdoorAddress = new Address("23 Berry Ln", "Houston", "TX");
        OutdoorEvent outdoor = new OutdoorEvent("Community Bake Sale", "Houston Residents! Come together and support our local teams at the bake sale!", "7/19/25", "12:00 PM", outdoorAddress);

        Console.WriteLine("Lecture Standard Details:");
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Lecture Full Details:");
        lecture.DisplayFullDetails();
        Console.WriteLine();
        Console.WriteLine("Lecture Short Description: ");
        lecture.ShortDescription();
        Console.WriteLine();

        Console.WriteLine("Reception Standard Details:");
        reception.DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Reception Full Details:");
        reception.DisplayFullDetails();
        Console.WriteLine();
        Console.WriteLine("Reception Short Description: ");
        reception.ShortDescription();
        Console.WriteLine();

        Console.WriteLine("Outdoor Standard Details:");
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Outdoor Full Details:");
        outdoor.DisplayFullDetails();
        Console.WriteLine();
        Console.WriteLine("Outdoor Description: ");
        outdoor.ShortDescription();

    }
}
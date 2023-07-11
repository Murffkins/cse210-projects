using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Standard event details:");
        Console.WriteLine("");

        Event lecture1 = new Lecture();
        Address address1 = new Address("1937 Elf Refuge", "Eastern Eriador", "Bruinen", 00001);
        lecture1.SetEventDetails("You Shall Not Pass", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "10/20/1955", "11:00am", address1);
        Console.WriteLine("#1");
        lecture1.DisplayStandardMessage();

        Console.WriteLine("");

        Event reception1 = new Reception();
        Address address2 = new Address("42 Cavemen Street", "Somewhere Near", "Betelgeuse", 04242);
        reception1.SetEventDetails("The Ultimate Question of Life", "In dictum non consectetur a erat nam at lectus urna. Diam maecenas ultricies mi eget mauris pharetra et ultrices.", "12/21/4242", "12:42pm", address2);
        Console.WriteLine("#2");
        reception1.DisplayStandardMessage();

        Console.WriteLine("");

        Event outdoorGathering1 = new OutdoorGathering();
        Address address3 = new Address("123 My Peanut Street", "Oceanic Abiss", "Davy Jones's Locker", 99999);
        ((OutdoorGathering)outdoorGathering1).SetOutdoorGatheringDetails("sunny");
        outdoorGathering1.SetEventDetails("I've Got a Jar of Dirt", "Eget dolor morbi non arcu. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing.", "01/01/0101", "6:00am", address3);
        Console.WriteLine("#3");
        outdoorGathering1.DisplayStandardMessage();

        Console.WriteLine("");
        Console.WriteLine("#############################################################################################################################################");
        Console.WriteLine("");


        Console.WriteLine("Detailed event info:");
        Console.WriteLine("");

        Event lecture2 = new Lecture();
        ((Lecture)lecture2).SetLectureDetails("Gandalf the Grey", 200);
        lecture2.SetEventDetails("You Shall Not Pass", "Netus et malesuada fames ac. Metus dictum at tempor commodo. Arcu felis bibendum ut tristique et egestas. Eu scelerisque felis imperdiet proin.", "10/20/1955", "11:00am", address1);
        Console.WriteLine("#1");
        lecture2.DisplayDetailedMessage();

        Console.WriteLine("");

        Event reception2 = new Reception();
        reception2.SetEventDetails("The Ultimate Question of Life", "Nunc id cursus metus aliquam eleifend mi. Integer malesuada nunc vel risus commodo viverra maecenas.", "12/21/4242", "12:42pm", address2);
        Console.WriteLine("#2");
        reception2.DisplayDetailedMessage();

        Console.WriteLine("");

        Event outdoorGathering2 = new OutdoorGathering();
        ((OutdoorGathering)outdoorGathering2).SetOutdoorGatheringDetails("sunny");
        outdoorGathering2.SetEventDetails("I've Got a Jar of Dirt", "Sit amet massa vitae tortor condimentum. Integer vitae justo eget magna.", "01/01/0101", "6:00am", address3);
        Console.WriteLine("#3");
        outdoorGathering2.DisplayDetailedMessage();

        Console.WriteLine("");
        Console.WriteLine("#############################################################################################################################################");
        Console.WriteLine("");

        Console.WriteLine("Quick Event details:");
        Console.WriteLine("");

        Event lecture3 = new Lecture();
        lecture3.SetEventDetails("You Shall Not Pass", "Quis varius quam quisque id diam vel. Nam at lectus urna duis convallis convallis tellus. Cras semper auctor neque vitae tempus quam.", "10/20/1955", "11:00am", address1);
        Console.WriteLine("#1");
        lecture3.DisplayShortMessage();

        Console.WriteLine("");

        Event reception3 = new Reception();
        reception3.SetEventDetails("The Ultimate Question of Life", "Leo in vitae turpis massa sed. Vestibulum mattis ullamcorper velit sed ullamcorper. Malesuada pellentesque elit eget gravida.", "12/21/4242", "12:42pm", address2);
        Console.WriteLine("#2");
        reception3.DisplayShortMessage();

        Console.WriteLine("");

        Event outdoorGathering3 = new OutdoorGathering();
        ((OutdoorGathering)outdoorGathering3).SetOutdoorGatheringDetails("sunny");
        outdoorGathering3.SetEventDetails("I've Got a Jar of Dirt", "Eget aliquet nibh praesent tristique magna sit amet purus. Tincidunt lobortis feugiat vivamus at augue. Scelerisque fermentum dui faucibus in.", "01/01/0101", "6:00am", address3);
        Console.WriteLine("#3");
        outdoorGathering3.DisplayShortMessage();

        Console.WriteLine("");




    }
}
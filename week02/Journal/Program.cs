using System;
using System.Data;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        string answer = "";
        while(answer != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    myJournal.AddEntry(AskForEntry());
                    break;
                case "2":
                    myJournal.DisplayAll();
                    break;
                case "3":
                    myJournal.LoadFromFile(AskForFile());
                    break;
                case "4":
                    myJournal.SaveToFile(AskForFile());
                    break;
                default:
                    break;
            }
        }
    }

    static Entry AskForEntry()
    {
        Entry newEntry = new Entry();

        DateTime date = DateTime.Today;
        newEntry._date = $"{date.Month}/{date.Day}/{date.Year}";

        PromptGenerator promptGenerator = new PromptGenerator();
        newEntry._promptText = promptGenerator.GetRandomPrompt();

        Console.WriteLine($"{newEntry._promptText}");
        Console.Write("> ");
        newEntry._entryText = Console.ReadLine();

        return newEntry;
    }

    static string AskForFile()
    {
        Console.WriteLine("What is the filename?");
        return Console.ReadLine();
    }
}
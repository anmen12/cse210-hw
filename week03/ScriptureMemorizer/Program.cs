//In addition to the core requirements, I have added a Scripture Generator class that picks a random scripture from a list to use.

using System;
using System.Collections;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        ScriptureGenerator scriptureGenerator = new ScriptureGenerator();
        Scripture scripture = scriptureGenerator.GenerateScripture();

        string response = "";
        while(response.ToLower() != "quit")
        {
            //Clear Console
            Console.Clear();

            //Print Verse(s)
            Console.WriteLine($"{scripture.GetDisplayText()}");
            Console.WriteLine();
            Console.WriteLine("Press enter to Continue or type 'quit' to finish:");
            response = Console.ReadLine();

            //Check for Complete Hidden
            if(scripture.IsCompletelyHidden())
            {
                break;
            }

            //Hide Words
            scripture.HideRandomWords(3);
        }
        //Print One Last Time
        Console.Clear();
        Console.WriteLine($"{scripture.GetDisplayText()}");
        Console.WriteLine();
    }
}
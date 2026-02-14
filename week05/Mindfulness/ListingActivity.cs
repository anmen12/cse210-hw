class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = ["When have you felt grateful for something this week?",
                                     "When have you prayed for something out of the ordinary this month?",
                                     "When have you needed to ask for help this month",
                                     "When have you forgotten something this week?",
                                     "When have you rememebered something this week?"];
    private List<string> _usedPrompts = new List<string>();

    public ListingActivity() : base()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good thing in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        for(int i = 0; i < 5; i++)
        {
            Console.Write($"{5 - i}");
            Thread.Sleep(1000);
            Console.Write($"\b");
        }
        Console.WriteLine($" \b");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(int.Parse(_duration));

        _count = 0;
        while(true)
        {
            DateTime currentTime = DateTime.Now;
            if(currentTime >= futureTime)
            {
                break;
            }

            Console.Write($"> ");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!\n");
    }
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        string potentialPrompt;

        while(_prompts.Count() != _usedPrompts.Count())
        {
            potentialPrompt = _prompts[randomGenerator.Next(0, _prompts.Count)];
            if(!_usedPrompts.Contains(potentialPrompt))
            {
                _usedPrompts.Add(potentialPrompt);
                return potentialPrompt;
            }
        }

        _usedPrompts.Clear();
        potentialPrompt = _prompts[randomGenerator.Next(0, _prompts.Count)];
        _usedPrompts.Add(potentialPrompt);
        return potentialPrompt;
    }
}
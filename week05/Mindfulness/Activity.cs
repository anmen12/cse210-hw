class Activity
{
    protected string _name;
    protected string _description;
    protected string _duration;

    public Activity()
    {
        ;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Console.ReadLine();

        Console.Clear();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }
    protected void ShowSpinner(int seconds)
    {
        List<char> symbols = ['|','/','-','\\'];
        for(int i = 0; i < seconds; i++)
        {
            foreach(char symbol in symbols)
            {
                Console.Write($"{symbol}");
                Thread.Sleep(250);
                Console.Write($"\b");
            }
        }
        Console.WriteLine($" \b");
    }
}
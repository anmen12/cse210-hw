class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you to relax by walking you through breathing in and out slowly. Clear your mind and focucs on your breathing.";
    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(int.Parse(_duration));

        Breath("Breath in...", 2);
        Breath("Now breath out...", 3);
        Console.WriteLine();

        while(true)
        {
            DateTime currentTime = DateTime.Now;
            if(currentTime >= futureTime)
            {
                break;
            }

            Breath("Breath in...", 4);
            Breath("Now breath out...", 6);
            Console.WriteLine();
        }
    }
    private void Breath(string message, int duration)
    {
        Console.Write($"{message}");
        for(int i = 0; i < duration; i++)
        {
            Console.Write($"{duration - i}");
            Thread.Sleep(1000);
            Console.Write($"\b");
        }
        Console.WriteLine($" \b");
    }
}
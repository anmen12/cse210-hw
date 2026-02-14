class ReflectingActivity : Activity
{
    private List<string> _prompts = ["Think of a time you remembered to do something",
                                     "When was a time you went out of your way for someone?",
                                     "Think of a time you thanked someone for something they did",
                                     "What was a time when you did something even when unforseen obstacles appeared?",
                                     "Think of a time when you did something knowing you might be looked down upon for doing so"];
    private List<string> _usedPrompts = new List<string>();
    private List<string> _questions = ["What thing helped you press onward?",
                                       "How did you see yourself after?",
                                       "What was something you thought about during the time?",
                                       "How do you think you would be if you didn't experience the time?",
                                       "What is something you wish to remember about the time?"];
    private List<string> _usedQuestions = new List<string>();

    public ReflectingActivity() : base()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on time in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DisplayPrompt();
        DisplayQuestions();
    }
    private string GetRandomPrompt()
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
    private string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        string potentialQuestion;

        while(_questions.Count() != _usedQuestions.Count())
        {
            potentialQuestion = _questions[randomGenerator.Next(0, _questions.Count)];
            if(!_usedQuestions.Contains(potentialQuestion))
            {
                _usedQuestions.Add(potentialQuestion);
                return potentialQuestion;
            }
        }

        _usedQuestions.Clear();
        potentialQuestion = _questions[randomGenerator.Next(0, _questions.Count)];
        _usedQuestions.Add(potentialQuestion);
        return potentialQuestion;
    }
    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {GetRandomPrompt()} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
    }
    private void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");

        Console.Write("You may begin in: ");
        for(int i = 0; i < 5; i++)
        {
            Console.Write($"{5 - i}");
            Thread.Sleep(1000);
            Console.Write($"\b");
        }
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(int.Parse(_duration));

        while(true)
        {
            DateTime currentTime = DateTime.Now;
            if(currentTime >= futureTime)
            {
                break;
            }

            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(12);
        }
        Console.WriteLine();
    }
}
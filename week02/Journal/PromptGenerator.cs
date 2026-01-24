class PromptGenerator
{
    private List<string> _prompts = ["Where is a place you visited?",
                                     "What is something you wish you had done differently?",
                                     "How happy are you with your day?",
                                     "What was something you really enjoyed today?",
                                     "How would you describe your habits?",
                                     "What is something you that you need to remember to do from today?"];

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        return _prompts[randomGenerator.Next(0, _prompts.Count + 1)];
    }
}

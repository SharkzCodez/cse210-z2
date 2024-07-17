class ReflectionActivity : Activity {

    List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    List<string> _reflectionQuestions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done something like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    string _prompt;

    public ReflectionActivity(string nameOfActivity, string activityDescription) : base(nameOfActivity, activityDescription) {
        _prompt = RandomPrompt(_prompts);
    }

    private string RandomPrompt(List<string> prompts) {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(prompts.Count);
        _prompt = prompts[randomIndex];
        return _prompt;
    }

    private void DisplayPrompt() {
        Console.WriteLine($"-- {_prompt} --");
    }

    public void RunActivity() {
        DateTime endTime = WelcomeMessage();
        DisplayPrompt();
        Thread.Sleep(3000);
        DateTime startTime = DateTime.Now;
        while (startTime < endTime) {
            string question = RandomPrompt(_reflectionQuestions);
            Console.Clear();
            Console.WriteLine($"\n-- {question} --");
            Spinner();
            startTime = DateTime.Now;
        }
        CompletionMessage();
    }
}
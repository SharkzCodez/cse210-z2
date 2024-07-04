using System;

 public class PromptGenerator
 {
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of today?", "What is something new you learned today?", "List three things you are grateful for today", "Did you see any animals today?", "What emotion did you feel the strongest today? Why?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        string newPrompt = _prompts[random.Next(0, 4)];
        Console.WriteLine(newPrompt);
        return newPrompt;
    }


 }
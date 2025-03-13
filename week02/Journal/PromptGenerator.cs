using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;

    public PromptGenerator()
    {
        _prompts = new List<string>();
        {
            "What's your favorite hobby?",
            "What's the best advice you've ever received?",
            "If you could travel anywhere, where would you go?",
            "What's the most interesting thing about you?",
            "What's your favorite book and why?",
            "If you could have dinner with any historical figure, who would it be?",
            "What's the biggest risk you've ever taken?",
            "What's one thing you're passionate about outside of work or school?"
        };
    

        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }
}

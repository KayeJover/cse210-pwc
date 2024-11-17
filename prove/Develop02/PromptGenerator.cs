using System;
using System.Collections.Generic;

public class PromptGenerator 
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What challenges did I overcome today?"
        "Who did I help or show kindness to today?"
        "If today were a chapter in my life story, what would the title be?"
    };

    public string GetRandomPrompt(List<string> _prompts)
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];

    }
}
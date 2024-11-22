using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures = new List<Scripture>();

    public void AddScriptures()
    {
        _scriptures.Add(new Scripture(new Reference("Mosiah", 2, 41), 
            "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God."));
        _scriptures.Add(new Scripture(new Reference("Alma", 37, 6), 
            "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass."));
        _scriptures.Add(new Scripture(new Reference("Psalm", 34, 4), 
            "I sought the Lord, and he answered me and delivered me from all my fears."));
        _scriptures.Add(new Scripture(new Reference("Romans", 15, 13), 
            "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise."));
        _scriptures.Add(new Scripture(new Reference("Moroni", 7, 42), 
            "Wherefore, if a man have faith he must needs have hope; for without faith there cannot be any hope."));
    }

    public void DisplayScriptureList()
    {
        
        for (int i = 0; i < _scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_scriptures[i].Reference}");
        }
    }

    public Scripture GetScriptureByIndex(int index)
    {
        if (index >= 0 && index < _scriptures.Count)
        {
            return _scriptures[index];
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return null;
        }
    }
}

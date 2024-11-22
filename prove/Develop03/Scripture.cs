using System;

public class Scripture
{
    public Reference Reference { get; private set; }
    public string Text { get; private set; }
    private string[] _words;
    private int _hiddenWordCount = 0;

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Text = text;
        _words = Text.Split(' ');
    }

    public void Display()
    {
        Console.WriteLine($"Scripture: {Reference}");
        Console.WriteLine(Text);
    }

    public void HideWords()
    {
        if (_hiddenWordCount >= _words.Length)
        {
            Console.WriteLine("All words are hidden.");
            return;
        }

        Random random = new Random();
        int wordsToHide = Math.Min(3, _words.Length - _hiddenWordCount); // Limit words hidden each time

        for (int i = 0; i < wordsToHide; i++)
        {
            int index;
            do
            {
                index = random.Next(_words.Length);
            } while (_words[index].StartsWith("_")); // Avoid hiding already hidden words

            _words[index] = new string('_', _words[index].Length);
            _hiddenWordCount++;
        }

        Console.WriteLine(string.Join(' ', _words));
    }
    }

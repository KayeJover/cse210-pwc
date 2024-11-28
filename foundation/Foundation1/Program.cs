using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create videos
        var videos = new List<Video>
        {
            new Video("My House Tour", "Ivana Alawi", 1320),
            new Video("Pork Chop Steak Recipe", "Vanjo Merano", 1260),
            new Video("Siargao 2024", "Marco Gallo", 1680),
            new Video("Fitness Hacks", "Fit Mike", 480)
        };

        // Add comments to the videos
        videos[0].AddComment(new Comment("Leonora", "This is the best house I’ve ever seen in Philippines."));
        videos[0].AddComment(new Comment("John", "I'm really happy miss Ivana because you finally reached the top. And there's no doubt that you deserve all the blessings!"));
        videos[0].AddComment(new Comment("Shin", "I'm currently studying fashion design, and the hermes pillow makes the ambience/the atmosphere cool."));

        videos[1].AddComment(new Comment("Delia", " I don’t like cooking but by the way you do you entice me to do it."));
        videos[1].AddComment(new Comment("Erlenda", "I like the way you marinate the pork chops I’l follow the way you prepare for the pork chops for marinating."));
        videos[1].AddComment(new Comment("Frank", " I'd really love to learn how to make this and your other recipes."));

        videos[2].AddComment(new Comment("Celine", "This vlog is so raw, pure, and filled with so much love."));
        videos[2].AddComment(new Comment("Heidi", "Nice music whose taste was it?"));
        videos[2].AddComment(new Comment("Ivan", "How much did the trip cost?"));

        videos[3].AddComment(new Comment("Jack", "Great tips for beginners."));
        videos[3].AddComment(new Comment("Louie", "I'm going to try this tomorrow!"));
        videos[3].AddComment(new Comment("Liam", "What equipment do you use?"));

        // Display information about each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Author}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}

// Video class
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // in seconds
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }
}

// Comment class
class Comment
{
    public string Author { get; set; }
    public string Text { get; set; }

    public Comment(string author, string text)
    {
        Author = author;
        Text = text;
    }
}

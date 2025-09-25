using System;
using System.Collections.Generic;

// Class to represent a comment on a video
public class Comment
{
    private string commenterName;
    private string text;

    public Comment(string commenterName, string text)
    {
        this.commenterName = commenterName;
        this.text = text;
    }

    public string CommenterName
    {
        get { return commenterName; }
    }

    public string Text
    {
        get { return text; }
    }
}

// Class to represent a YouTube video
public class Video
{
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }

    public string Title
    {
        get { return title; }
    }

    public string Author
    {
        get { return author; }
    }

    public int LengthInSeconds
    {
        get { return lengthInSeconds; }
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Trying Piggy Wee's BBQ Ribs!", "Foodie Life", 590);
        video1.AddComment(new Comment("Linda", "Absolutely delicious! The sauce outshines everything."));
        video1.AddComment(new Comment("Carlos", "Best ribs I’ve had in town."));
        video1.AddComment(new Comment("Dan", "Too fatty for my taste, expected leaner meat."));
        video1.AddComment(new Comment("Mia", "The portion size was perfect."));
        video1.AddComment(new Comment("Tina", "The ribs were cold when served."));
        videos.Add(video1);

        Video video2 = new Video("Review: Happy Piglet Restaurant's Famous Ribs", "Eat With Pete", 720);
        video2.AddComment(new Comment("Sofia", "The tenderness is unreal."));
        video2.AddComment(new Comment("James", "A bit sweet for my taste, but still great."));
        video2.AddComment(new Comment("Paul", "Honestly, I found them overpriced compared to other places."));
        video2.AddComment(new Comment("Rita", "Would love a spicier version!"));
        video2.AddComment(new Comment("Elena", "Perfect with fries!"));
        videos.Add(video2);

        Video video3 = new Video("Barbecue Ribs Taste Test at Happy Piglet", "Jane's Food Adventures", 650);
        video3.AddComment(new Comment("Mike", "Smoky flavor is amazing, highly recommend."));
        video3.AddComment(new Comment("Oliver", "I'll bring my friends next time."));
        video3.AddComment(new Comment("Tina", "Service was slow, but the food made up for it."));
        video3.AddComment(new Comment("George", "Waited too long for my order—I hope the speed improves."));
        video3.AddComment(new Comment("Linda", "The sauce was too sweet for me."));
        videos.Add(video3);

        Video video4 = new Video("Family Dinner at Happy Piglet Restaurant", "Family Foodies", 845);
        video4.AddComment(new Comment("Sarah", "My kids loved the ribs!"));
        video4.AddComment(new Comment("Thomas", "Service was excellent, ribs were fantastic."));
        video4.AddComment(new Comment("Nina", "Great place for celebrations."));
        video4.AddComment(new Comment("Dan", "A little bit pricey but worth it for special occasions."));
        video4.AddComment(new Comment("Carlos", "Portion sizes could be bigger."));
        videos.Add(video4);

        // Display information for each video and its comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"\t{comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}

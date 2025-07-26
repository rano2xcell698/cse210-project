using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Tutorial for Beginners", "CodeAcademy", 1200);
        video1.AddComment(new Comment("Alice", "Very helpful!"));
        video1.AddComment(new Comment("Bob", "I finally understand classes."));
        video1.AddComment(new Comment("Charlie", "Great visuals too."));
        videos.Add(video1);

        Video video2 = new Video("Top 10 Coding Interview Tips", "TechWithTim", 800);
        video2.AddComment(new Comment("David", "Tip #7 was gold!"));
        video2.AddComment(new Comment("Eva", "Subbed and liked!"));
        video2.AddComment(new Comment("Frank", "You saved my career."));
        videos.Add(video2);

        Video video3 = new Video("Travel Vlog: Kenya Safari", "WanderWorld", 1500);
        video3.AddComment(new Comment("Grace", "Absolutely stunning!"));
        video3.AddComment(new Comment("Henry", "Bucket list item now."));
        video3.AddComment(new Comment("Isla", "Your drone shots are amazing."));
        videos.Add(video3);

        Video video4 = new Video("How to Bake Banana Bread", "HomeChef", 600);
        video4.AddComment(new Comment("Jack", "Came out perfectly!"));
        video4.AddComment(new Comment("Kelly", "Thanks for the recipe."));
        video4.AddComment(new Comment("Liam", "Best baking tutorial ever."));
        videos.Add(video4);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetAllComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}

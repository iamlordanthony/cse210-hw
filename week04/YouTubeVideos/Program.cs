using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold all videos
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Exploring Ghana", "Lord Anthony", 320);
        video1.AddComment(new Comment("Nana", "Loved this video!"));
        video1.AddComment(new Comment("Ama", "Informative and well edited."));
        video1.AddComment(new Comment("Kojo", "Can't wait to visit!"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("C# Abstraction Tutorial", "Dev Guru", 540);
        video2.AddComment(new Comment("Student123", "Super helpful, thanks!"));
        video2.AddComment(new Comment("CodeLover", "I finally get abstraction."));
        video2.AddComment(new Comment("JaneDoe", "Clear and concise."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("How to Cook Jollof Rice", "Mama Cooks", 450);
        video3.AddComment(new Comment("Foodie", "Looks delicious!"));
        video3.AddComment(new Comment("ChefMan", "Great technique."));
        video3.AddComment(new Comment("Lydia", "Trying this tonight."));
        videos.Add(video3);

        // Display all video information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine(new string('-', 40)); // Separator line
        }
    }
}

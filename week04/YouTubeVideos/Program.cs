using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.AddComment(new Comment("Alex", "Interesting video."));
        video1.AddComment(new Comment("Sam", "I learned something new."));
        video1.AddComment(new Comment("Jordan", "Thanks for sharing."));

        Video video2 = new Video("Video 2", "Author 2", 300);
        video2.AddComment(new Comment("Taylor", "Great explanation."));
        video2.AddComment(new Comment("Morgan", "Very helpful."));
        video2.AddComment(new Comment("Riley", "I enjoyed this."));

        Video video3 = new Video("Video 3", "Author 3", 240);
        video3.AddComment(new Comment("Casey", "Well done."));
        video3.AddComment(new Comment("Jamie", "This was useful."));
        video3.AddComment(new Comment("Avery", "Looking forward to more."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Comments ({video.GetCommentCount()}):");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    $"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}
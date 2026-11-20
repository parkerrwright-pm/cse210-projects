using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.Comments.Add("Comment 1");
        video1.Comments.Add("Comment 2");

        Video video2 = new Video("Video 2", "Author 2", 300);
        video2.Comments.Add("Comment 3");
        video2.Comments.Add("Comment 4");

        List<Video> videos = new List<Video> { video1, video2 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Comments ({video.GetCommentCount()}):");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment}");
            }
            Console.WriteLine();
        }
    }
}
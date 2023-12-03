using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Video 1, How to make Alchol Ink Coasters", "Laura Folk", 360);
        Video video2 = new Video("Video 2, How to crochet hotpads", "Allie Folk", 240);
        Video video3 = new Video("Video 3, How to do oil painting", "Maddie Folk", 180);

        // Add comments to videos
        video1.AddComment("Allie C", "Great video!");
        video1.AddComment("Bobby J", "I learned a lot from this.");
        video1.AddComment("Billie A", "Super interesting.");

        video2.AddComment("Bobby Jo", "Awesome content!");
        video2.AddComment("Peggy Sue", "Keep up the good work.");
        video2.AddComment("Sunny F", "Love this going to try it.");

        video3.AddComment("Patty S", "Interesting topic.");
        video3.AddComment("Lori Lynn", "I enjoyed watching this.");
        video3.AddComment("Sammy F", "Keep up the good work.");

        // Create a list to store videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video in the list
        foreach (var video in videos)
        {
            // Get video information as a string
            string videoInfo = video.GetVideoInfo();

            // Display the video information
            Console.WriteLine(videoInfo);
        }
    }
}
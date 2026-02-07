using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        for(int i = 1; i < 4; i++)
        {
            videos.Add(new Video($"Video {i}", $"Author {i}" , i * 100));
            for(int j = 1; j < 4; j++)
            {
                videos[videos.Count - 1].AddComment($"Commenter {j}", $"I rate this a {j} out of 5");
            }
        }

        foreach(Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
        }
    }
}
// Encapsulation is not in use.
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Minecraft Bugs In 1.20.60", "Everything Minecraft", 455);
        Comment comment1 = new Comment("Sir Gwain", "Dude this is really cool!");
        Comment comment2 = new Comment("Rick", "Very nice to have");
        Comment comment3 = new Comment("MC Fan", "Your the best Everything Minecraft!");
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);
        videos.Add(video1);

        Video video2 = new Video("Sonic Speed Simulator New Skins!", "Sonicster", 311);
        Comment comment4 = new Comment("SuperSpeed", "Cool! I'm going to get them");
        Comment comment5 = new Comment("Silver", "I like the new skins");
        Comment comment6 = new Comment("SonicFan1", "Lets go! more sonic skins!");
        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);
        videos.Add(video2);

        Video video3 = new Video("History of Einstein", "Historical", 1383);
        Comment comment7 = new Comment("Learner", "I never knew this about Einstein");
        Comment comment8 = new Comment("Rick", "Keep up the good work of teaching us");
        Comment comment9 = new Comment("Max", "Eistein is my favorite scientist.");
        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void DisplayVideoInfo()
    {
        int duration = ((int)Math.Floor(((double)_length)/60));
        int seconds = _length % 60;
        int numComments = _comments.Count();
        Console.WriteLine($"{_title} by {_author}. Duration: {duration}:{seconds} Number of comments: {numComments}");

        Console.WriteLine("Comments:");
        for (int i = 0; i < numComments; i++)
        {
            _comments[i].DisplayCommentInfo();
        }
        Console.WriteLine();
    }
}
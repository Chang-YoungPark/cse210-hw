using System;
using System.Collections.Generic;

// Video class
public class Video
{
    public string _videoFile;
    private string _title;
    private string _author;
    private int _length; 
    private int _numberComment = 0;

    List<Comment> _comments = new List<Comment>();

    // Video constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
 
    // Add Comment
    public void AddComment(string namePerson, string textComment)
    {
        _numberComment += 1;
        Comment comment = new Comment(namePerson, textComment);
        _comments.Add(comment);
    }

    // Display
    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine($"Title: {_title}, Author: {_author}");
        Console.WriteLine("");
        Console.WriteLine($"Number of comment : {_numberComment}");
        foreach(Comment comment in _comments )
        {
            Console.WriteLine($"Commenter's name : {comment._namePerson}");
            Console.WriteLine($"The text : {comment._textComment}");
            Console.WriteLine("");
        }
    }

}



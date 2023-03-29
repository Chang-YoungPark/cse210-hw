using System;
using System.Collections.Generic;

// Comment class
public class Comment
{
    public string _namePerson;
    public string _textComment;     

    List<Comment> _comments = new List<Comment>();

    public Comment()
    {
        _namePerson = "";
        _textComment = "";
    }  

    public Comment(string namePerson, string textComment)
    {
        _namePerson = namePerson;
        _textComment = textComment;
    }  
}



using System;
using System.Collections.Generic;

// Comment class
public class Comment
{
    public string _namePerson;
    public string _textComment;     

    List<Comment> _comments = new List<Comment>();
    
    // Constructor 
    public Comment()
    {
        _namePerson = "";
        _textComment = "";
    }  
    
    // Constructor with parameters
    public Comment(string namePerson, string textComment)
    {
        _namePerson = namePerson;
        _textComment = textComment;
    }  
}



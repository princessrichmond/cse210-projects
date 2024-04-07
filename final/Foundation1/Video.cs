using System;

public class Video{
    public string _title{
        get; 
        set;}
    public string _author{
        get;
        set;
    }
    public int _lengthSeconds{
        get;
        set;
    }

    public List<Comment> _comments{
        get;
        set;
    }

    public Video(string title, string author, int lengthSeconds){
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment){
        _comments.Add(comment);
    }

    public int GetNumberOfComments(){
        return _comments.Count;
    }
}
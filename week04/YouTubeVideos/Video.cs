using System.ComponentModel;
using System.Collections.Generic;

public class Video
{
//  private string _title;
//  private string _author;
//  private int _length;

 public string _title;
 public string _author;
 public int _length;

 public List<Comment> _comments;
 
//  public Video(string videoTitle, string videoAuthor, int videoLength)
//  {
//     _title = videoTitle;
//     _author = videoAuthor;
//     _length = videoLength;
//     _comments = new List<Comment>();
//  }

 public Video()
 {
 }

 public void AddComment(string name, string text)
 { 
   Comment comment = new Comment();
   comment._personName = name;
   comment._textComment = text;
   _comments.Add(comment);
 }
 public int NumberOfComments()
 {
    return _comments.Count;
 }
 
 public void DisplayComment()
 {
   foreach(Comment comment in _comments)
   {
     string name = comment._personName;
     string text = comment._textComment;
     Console.WriteLine($"{name}: {text}");
   }
 }
 public string DisplayDetails()
 {
    return $"{_title}, author: {_author}, time: {_length} seconds";
 }

}
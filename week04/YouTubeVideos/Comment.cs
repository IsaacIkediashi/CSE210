public class Comment
{
  // private string _personName;
  // private string _textComment;


  public string _personName;
  public string _textComment;

  // public Comment(string name, string text)
  // {
  //  _personName = name;
  //  _textComment = text;
  // }
  public Comment()
  {
  }
  public string GetComments()
  {
    return $"{_personName}: {_textComment}"; 
  }
}
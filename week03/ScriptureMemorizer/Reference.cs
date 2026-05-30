public class Reference
{
  private string _book;
  private int _chapter;
  private int _verse;
  private int _endVerse;
  public Reference(string book, int chapter, int verse)
  {
    _book = book;
    _chapter = chapter;
    _verse = verse;
    _endVerse = verse;
  }
  public Reference(string book, int chapter, int beginVerse, int endVerse)
  {
    _book = book;
    _chapter = chapter;
    _verse = beginVerse;
    _endVerse = endVerse;
  }
  
  public string GetBibleReference()
  {
    if (_verse != _endVerse)
    {
      return $"{_book} {_chapter}:{_verse.ToString()}-{_endVerse.ToString()}";
    }
    return  $"{_book} {_chapter}:{_verse.ToString()}";  
  }
}
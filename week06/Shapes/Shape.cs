public class Shape
{
  private string _color;
  public Shape()
  {
  }
 public void SetColor(string colorName)
 {
  _color = colorName;
 }

 public string GetColor()
 {
  return _color;
 }

 public virtual double GetArea()
 {
   return (double)5 * (double)5;
 }

}
public class Square : Shape
{
 private double _side;
 public Square(double length)
 {
  _side = (double)length;
 }

 public override double GetArea()
 {
  double area = (double)_side * (double)_side;
  return area;
 }
}
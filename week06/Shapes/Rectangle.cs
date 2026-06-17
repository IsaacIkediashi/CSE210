public class Rectangle : Shape
{
 public double _length;
 public double _width;
 public Rectangle(double length, double width)
 {
   _length =  length;
   _width = width;
 }

 public override double GetArea()
 {
  double area = (double)_length * (double)_width;
  return area;
 }


}
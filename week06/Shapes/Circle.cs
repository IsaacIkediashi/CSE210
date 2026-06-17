public class Circle : Shape
{
 private double pi = Math.PI;
 private double _radius;
 public Circle(double radius)
 {
  _radius = radius;
 }

 public override double GetArea()
 {
  double piValue = Math.Round(pi, 2);
  double area =  (double)piValue * (double)(_radius * _radius);
  return area;
 }

}
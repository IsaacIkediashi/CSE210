public class Cycling: Activity
{
 private double _speed;
 public Cycling(double kilometerPerHour, int minutes)
 {
   SetActivity("Cycling");
   _speed = kilometerPerHour;
   _activityLength = minutes;

 }
 
 public override double Distance()
 { 
   double distance = _speed / _activityLength;
   return Math.Round(distance, 2);
 }
 public override double Speed()
 {
   return Math.Round(_speed, 2);
 }
 public override double Pace()
 { 
   double pace = _activityLength / Distance();
   return Math.Round(pace, 2);
 }
}
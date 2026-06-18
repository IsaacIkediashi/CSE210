public class Swimming : Activity
{
 private int _laps;

 public Swimming(int laps, int minutes)
 {
   SetActivity("Swimming");
   _laps = laps;
   _activityLength = minutes;
 }
 
 public override double Distance()
 { 
   double distance = _laps * 50 / 1000;
   return Math.Round(distance, 2);
 }
 public override double Speed()
 {
  double speed = Distance() / _activityLength;
  return Math.Round(speed, 2);
 }
 public override double Pace()
 {
   double pace = _activityLength / Distance();
   return Math.Round(pace, 2);
 }
}
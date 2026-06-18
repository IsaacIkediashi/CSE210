public class Running : Activity
{
  private double _distance;
 
  public Running(double meters, int minutes)
  {
    SetActivity("Running");
    _distance = meters;
    _activityLength = minutes;
  }
   
   public override double Distance()
   {
     return Math.Round(_distance, 2);
   }
   public override double Speed()
   {
    return (double)_distance / _activityLength;
   }
   public override double Pace()
   {
     return _activityLength / (double)_distance;
   } 
}
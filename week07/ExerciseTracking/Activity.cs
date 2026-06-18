public abstract class Activity
{
  private DateTime dateTime = DateTime.Now;
  private string _activityType; 
  protected int _activityLength;

  
  public Activity()
  {   
  }

  public abstract double Distance();
  public abstract double Speed();
  public abstract double Pace();

  public string GetSummary()
  {
   string formattedDate = dateTime.ToString("dd MMM yyyy");
   return $"{formattedDate} {_activityType} ({_activityLength} min): Distance - {Distance()} km, Speed - {Speed()} kph, Pace: {Pace()} min per km";
  }
  
  
  public void SetActivity(string activity)
  {
    _activityType = activity;
  }

}
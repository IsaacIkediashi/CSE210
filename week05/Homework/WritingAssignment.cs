public class WritingAssignment : Assignment
{
 private string _title;
 
 public WritingAssignment(string name, string topic, string title) : base(name, topic)
 {
    _title = title;
 }
 public string GetWritingInformation()
 {
    Console.WriteLine();
    return $"{GetSummary()}\n{_title} by {_studentName}";
    // return $"{GetSummary()}\n{_title} by {GetStudentName()}";
 }
}


using System.ComponentModel;

public class Assignment
{
    private string _studentName = " ";
    private string _topic = " ";

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }


    // Get the students name
    public string GetStudentName()
    {
        return _studentName;
    }
    // Get topic from student
    public string GetTopic()
    {
        return _topic;
    }
    // Set student topic
    public string GetSummary()
    {
        return $"{_studentName} -- {_topic}";
    }
}
namespace Domain.Entites;

public class TimeTable
{
    public int TimeTableId { get; set; }
    public string Day { get; set; }
    public string Time { get; set; }
    public string Subject { get; set; }
    public List<Classroom> Classrooms { get; set; }

    public TimeTable()
    {
        
    }

    public TimeTable(int timetableid, string day, string time, string subject)
    {
        TimeTableId = timetableid;
        Day = day;
        Time = time;
        Subject = subject;
    }
}
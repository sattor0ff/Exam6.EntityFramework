namespace Domain.Dtos;

public class TimeTableDto
{
    public int TimeTableId { get; set; }
    public string Day { get; set; }
    public string Time { get; set; }
    public string Subject { get; set; }

    public TimeTableDto()
    {
        
    }

    public TimeTableDto(int timetableid, string day, string time, string subject)
    {
        TimeTableId = timetableid;
        Day = day;
        Time = time;
        Subject = subject;
    }
}
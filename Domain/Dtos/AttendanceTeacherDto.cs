namespace Domain.Dtos;


public class AttendanceTeacherDto
{
    public int AttendanceTeacherId { get; set; }
    public DateTime Date { get; set; }
    public bool Status { get; set; }
    public int TeacherId { get; set; }

    public AttendanceTeacherDto()
    {
        
    }

    public AttendanceTeacherDto(int attendanseteacherid, DateTime date, bool status, int teacherid)
    {
        AttendanceTeacherId = attendanseteacherid;
        Date = date;
        Status = status;
        TeacherId = teacherid;
    }
}
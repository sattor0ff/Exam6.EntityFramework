namespace Domain.Dtos;

public class AttendanceStudentDto
{
    public int AttendanceStudentId { get; set; }
    public DateTime Date { get; set; }
    public bool Status { get; set; }
    public int StudentId { get; set; }

    public AttendanceStudentDto()
    {
        
    }

    public AttendanceStudentDto(int attendancestudentid, DateTime date, bool status, int studentid)
    {
        AttendanceStudentId = attendancestudentid;
        Date = date;
        Status = status;
        StudentId = studentid;
    }
}
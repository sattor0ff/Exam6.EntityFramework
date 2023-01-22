using System.ComponentModel.DataAnnotations;
namespace Domain.Entites;


public class AttendanceStudent
{
    [Key]
    public int AttendanceStudentId { get; set; }
    public DateTime Date { get; set; }
    public bool Status { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }

    public AttendanceStudent()
    {
        
    }

    public AttendanceStudent(int attendancestudentid, DateTime date, bool status, int studentid)
    {
        AttendanceStudentId = attendancestudentid;
        Date = date;
        Status = status;
        StudentId = studentid;
    }
}
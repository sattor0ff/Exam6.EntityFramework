namespace Domain.Entites;
using System.ComponentModel.DataAnnotations;


public class AttendanceTeacher
{
    [Key]
    public int AttendanceTeacherId { get; set; }
    public DateTime Date { get; set; }
    public bool Status { get; set; }
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }

    public AttendanceTeacher()
    {
        
    }

    public AttendanceTeacher(int attendanseteacherid, DateTime date, bool status, int teacherid)
    {
        AttendanceTeacherId = attendanseteacherid;
        Date = date;
        Status = status;
        TeacherId = teacherid;
    }
}
using Domain.Dtos;
using Domain.Entites;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class AttendanceStudentService
{
    private readonly DataContext _context;

    public AttendanceStudentService(DataContext context)
    {
        _context = context;
    }
    
    public List<AttendanceStudentDto> GetAttendanceStudents()
    {
        return _context.AttendanceStudents.Select(x=>new AttendanceStudentDto(x.AttendanceStudentId, x.Date, x.Status, x.StudentId)).ToList();
    }
    
    public void AddAttendanceStudent(AttendanceStudentDto attendance)
    {
        try
        {
            var added = new AttendanceStudent(){
            AttendanceStudentId = attendance.AttendanceStudentId,
            Date = attendance.Date,
            Status = attendance.Status,
            StudentId = attendance.StudentId
        };
        _context.AttendanceStudents.Add(added);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void UpdateAttendanceStudent(AttendanceStudentDto attendance)
    {
        try
        {
            var updated = new AttendanceStudent(attendance.AttendanceStudentId, attendance.Date, attendance.Status, attendance.StudentId);
        _context.AttendanceStudents.Update(updated);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void DeleteAttendanceStudent(int id)
    {
        var deleted = _context.AttendanceStudents.First(x => x.AttendanceStudentId == id);
        _context.AttendanceStudents.Remove(deleted);
        _context.SaveChanges();
    }
}

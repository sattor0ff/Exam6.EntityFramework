using Domain.Dtos;
using Domain.Entites;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class AttendanceTeacherService
{
    private readonly DataContext _context;

    public AttendanceTeacherService(DataContext context)
    {
        _context = context;
    }
    
    public List<AttendanceTeacherDto> GetAttendanceTeachers()
    {
        return _context.AttendanceTeachers.Select(x=>new AttendanceTeacherDto(x.AttendanceTeacherId, x.Date, x.Status, x.TeacherId)).ToList();
    }
    
    public void AddAttendanceTeacher(AttendanceTeacherDto attendance)
    {
        try
        {
            var added = new AttendanceTeacher()
        {
            AttendanceTeacherId = attendance.AttendanceTeacherId,
            Date = attendance.Date,
            Status = attendance.Status,
            TeacherId = attendance.TeacherId
        };
        _context.AttendanceTeachers.Add(added);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void UpdateAttendanceTeacher(AttendanceTeacherDto attendance)
    {
        try
        {
            var updated = new AttendanceTeacher(attendance.AttendanceTeacherId, attendance.Date, attendance.Status, attendance.TeacherId);
        _context.AttendanceTeachers.Update(updated);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void DeleteAttendanceTeacher(int id)
    {
        var deleted = _context.AttendanceTeachers.First(x => x.AttendanceTeacherId == id);
        _context.AttendanceTeachers.Remove(deleted);
        _context.SaveChanges();
    }
}
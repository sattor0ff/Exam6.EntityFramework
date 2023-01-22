using Domain.Dtos;
using Domain.Entites;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class ClassroomService
{
    private readonly DataContext _context;

    public ClassroomService(DataContext context)
    {
        _context = context;
    }
    
    public List<ClassroomDto> GetClassrooms()
    {
        return _context.Classrooms.Select(x=>new ClassroomDto(x.ClassroomId, x.Section, x.Grade, x.TeacherId, x.TimeTableId)).ToList();
    }
    
    public void AddClassroom(ClassroomDto classroom)
    {
        try
        {
            var added = new Classroom()
        {
            ClassroomId = classroom.ClassroomId,
            Section = classroom.Section,
            Grade = classroom.Grade,
            TeacherId = classroom.TeacherId,
            TimeTableId = classroom.TimeTableId
        };
        _context.Classrooms.Add(added);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void UpdateClassroom(ClassroomDto classroom)
    {
        try
        {
            var updated = new Classroom(classroom.ClassroomId, classroom.Section, classroom.Grade, classroom.TeacherId, classroom.TimeTableId);
        _context.Classrooms.Update(updated);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void DeleteClassroom(int id)
    {
        var deleted = _context.Classrooms.First(x => x.ClassroomId == id);
        _context.Classrooms.Remove(deleted);
        _context.SaveChanges();
    }
}
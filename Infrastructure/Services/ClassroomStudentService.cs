using Domain.Dtos;
using Domain.Entites;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class ClassroomStudentService
{
    private readonly DataContext _context;

    public ClassroomStudentService(DataContext context)
    {
        _context = context;
    }
    
    public List<ClassroomStudentDto> GetClassroomStudents()
    {
        return _context.ClassroomStudents.Select(x=>new ClassroomStudentDto(x.Id, x.StudentId, x.ClassroomId)).ToList();
    }
    
    public void AddClassroomStudent(ClassroomStudentDto classroomStudent)
    {
        try
        {
            var added = new ClassroomStudent()
        {
            StudentId = classroomStudent.StudentId,
            ClassroomId = classroomStudent.ClassroomId
        };
        _context.ClassroomStudents.Add(added);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void UpdateClassroomStudent(ClassroomStudentDto classroomStudent)
    {
        try
        {
            var updated = new ClassroomStudent(classroomStudent.Id, classroomStudent.StudentId, classroomStudent.ClassroomId);
        _context.ClassroomStudents.Update(updated);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void DeleteClassroomStudent(int id)
    {
        var deleted = _context.ClassroomStudents.First(x => x.StudentId == id);
        _context.ClassroomStudents.Remove(deleted);
        _context.SaveChanges();
    }
}
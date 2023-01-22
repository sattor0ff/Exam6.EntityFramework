using Domain.Dtos;
using Domain.Entites;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class SubjectService
{
    private readonly DataContext _context;

    public SubjectService(DataContext context)
    {
        _context = context;
    }
    
    public List<SubjectDto> GetSubjects()
    {
        return _context.Subjects.Select(x=>new SubjectDto(x.SubjectId, x.Name, x.Grade, x.Description, x.ClassroomId)).ToList();
    }
    
    public void AddSubject(SubjectDto subject)
    {
        try
        {
            var added = new Subject()
        {
            SubjectId = subject.SubjectId,
            Name = subject.Name,
            Grade = subject.Grade,
            Description = subject.Description,
            ClassroomId = subject.ClassroomId
        };
        _context.Subjects.Add(added);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void UpdateSubject(SubjectDto subject)
    {
        try
        {
            var updated = new Subject(subject.SubjectId, subject.Name, subject.Grade, subject.Description, subject.ClassroomId);
        _context.Subjects.Update(updated);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void DeleteSubject(int id)
    {
        var deleted = _context.Subjects.First(x => x.SubjectId == id);
        _context.Subjects.Remove(deleted);
        _context.SaveChanges();
    }
}
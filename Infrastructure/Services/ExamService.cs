using Domain.Dtos;
using Domain.Entites;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class ExamService
{
    private readonly DataContext _context;

    public ExamService(DataContext context)
    {
        _context = context;
    }
    
    public List<ExamDto> GetExams()
    {
        return _context.Exams.Select(x=>new ExamDto(x.ExamId, x.Date, x.Name, x.Type)).ToList();
    }
    
    public void AddExam(ExamDto exam)
    {
        try
        {
            var added = new Exam()
        {
            ExamId = exam.ExamId,
            Date = exam.Date,
            Name = exam.Name,
            Type = exam.Type
        };
        _context.Exams.Add(added);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void UpdateExam(ExamDto exam)
    {
        try
        {
            var updated = new Exam(exam.ExamId, exam.Date, exam.Name, exam.Type);
        _context.Exams.Update(updated);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void DeleteExam(int id)
    {
        var deleted = _context.Exams.First(x => x.ExamId == id);
        _context.Exams.Remove(deleted);
        _context.SaveChanges();
    }
}
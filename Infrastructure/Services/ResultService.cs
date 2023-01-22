using Domain.Dtos;
using Domain.Entites;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class ResultService
{
    private readonly DataContext _context;

    public ResultService(DataContext context)
    {
        _context = context;
    }
    
    public List<ResultDto> GetResults()
    {
        return _context.Results.Select(x=>new ResultDto(x.Id, x.ExamId, x.StudentId, x.SubjectId, x.Marks)).ToList();
    }
    
    public void AddResult(ResultDto result)
    {
        try
        {
            var added = new Result()
        {
            Id = result.Id,
            ExamId = result.ExamId,
            StudentId = result.StudentId,
            SubjectId = result.SubjectId,
            Marks = result.Marks
        };
        _context.Results.Add(added);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void UpdateResult(ResultDto result)
    {
        try
        {
            var updated = new Result(result.Id, result.ExamId, result.StudentId, result.SubjectId, result.Marks);
        _context.Results.Update(updated);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void DeleteResult(int id)
    {
        var deleted = _context.Results.First(x => x.Id == id);
        _context.Results.Remove(deleted);
        _context.SaveChanges();
    }
}
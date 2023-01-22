using Domain.Dtos;
using Domain.Entites;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class IssueService
{
    private readonly DataContext _context;

    public IssueService(DataContext context)
    {
        _context = context;
    }
    
    public List<IssueDto> GetIssues()
    {
        return _context.Issues.Select(x=>new IssueDto(x.IssueId, x.Type, x.Detail, x.IsResolved, x.StudentId)).ToList();
    }
    
    public void AddIssue(IssueDto issue)
    {
        try
        {
            var added = new Issue()
        {
            IssueId = issue.IssueId,
            Type = issue.Type,
            Detail = issue.Detail,
            IsResolved = issue.IsResolved,
            StudentId = issue.StudentId
        };
        _context.Issues.Add(added);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void UpdateIssue(IssueDto issue)
    {
        try
        {
            var updated = new Issue(issue.IssueId, issue.Type, issue.Detail, issue.IsResolved ,issue.StudentId);
        _context.Issues.Update(updated);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void DeleteIssue(int id)
    {
        var deleted = _context.Issues.First(x => x.IssueId == id);
        _context.Issues.Remove(deleted);
        _context.SaveChanges();
    }
}
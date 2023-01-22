using System.ComponentModel.DataAnnotations;
namespace Domain.Entites;

public class Issue
{
    [Key]
    public int IssueId { get; set; }
    public string Type { get; set; }
    public string Detail { get; set; }
    public bool IsResolved { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }

    public Issue()
    {
        
    }

    public Issue(int issueid, string type, string detail, bool isresolved, int studentid)
    {
        IssueId = issueid;
        Type = type;
        Detail = detail;
        IsResolved = isresolved;
        StudentId = studentid;
    }
}
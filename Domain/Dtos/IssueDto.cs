namespace Domain.Dtos;

public class IssueDto
{
    public int IssueId { get; set; }
    public string Type { get; set; }
    public string Detail { get; set; }
    public bool IsResolved { get; set; }
    public int StudentId { get; set; }

    public IssueDto()
    {
        
    }

    public IssueDto(int issueid, string type, string detail, bool isresolved, int studentid)
    {
        IssueId = issueid;
        Type = type;
        Detail = detail;
        IsResolved = isresolved;
        StudentId = studentid;
    }
}
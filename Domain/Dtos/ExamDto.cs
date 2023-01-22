namespace Domain.Dtos;

public class ExamDto
{
    public int ExamId { get; set; }
    public DateTime Date { get; set; }
    public string Name { get; set; }
    public int Type { get; set; }

    public ExamDto()
    {
        
    }

    public ExamDto(int examid, DateTime date, string name, int type)
    {
        ExamId = examid;
        Date = date;
        Name = name;
        Type = type;
    }
}
namespace Domain.Entites;

public class Exam
{
    public int ExamId { get; set; }
    public DateTime Date { get; set; }
    public string Name { get; set; }
    public int Type { get; set; }
    public List<Result> Results { get; set; }

    public Exam()
    {
        
    }

    public Exam(int examid, DateTime date, string name, int type)
    {
        ExamId = examid;
        Date = date;
        Name = name;
        Type = type;
    }
}
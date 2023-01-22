namespace Domain.Dtos;

public class ResultDto
{
    public int Id { get; set; }
    public int ExamId { get; set; }
    public int StudentId { get; set; }
    public int SubjectId { get; set; }
    public int Marks { get; set; }

    public ResultDto()
    {
        
    }

    public ResultDto(int id, int examid, int studentid, int subjectid, int marks)
    {
        Id = id;
        ExamId = examid;
        StudentId = studentid;
        SubjectId = subjectid;
        Marks = marks;
    }
}
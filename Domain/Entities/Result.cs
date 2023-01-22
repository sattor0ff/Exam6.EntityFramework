using System.ComponentModel.DataAnnotations;
namespace Domain.Entites;

public class Result
{
    [Key]
    public int Id { get; set; }
    public int ExamId { get; set; }
    public int StudentId { get; set; }
    public int SubjectId { get; set; }
    public int Marks { get; set; }
    public Student Student { get; set; }
    public Subject Subject { get; set; }
    public Exam Exam { get; set; }

    public Result()
    {
        
    }

    public Result(int id, int examtid, int studentid, int subjectid, int marks)
    {
        Id = id;
        ExamId = examtid;
        StudentId = studentid;
        SubjectId = subjectid;
        Marks = marks;
    }
}
namespace Domain.Entites;

public class Subject
{
    public int SubjectId { get; set; }
    public string Name { get; set; }
    public int Grade { get; set; }
    public string Description { get; set; }
    public int ClassroomId { get; set; }
    public Classroom Classroom { get; set; }
    public List<Result> Results { get; set; }

    public Subject()
    {
        
    }

    public Subject(int subjectid, string name, int grade, string description, int classroomid)
    {
        SubjectId = subjectid;
        Name = name;
        Grade = grade;
        Description = description; 
        ClassroomId = classroomid;  
    }
}
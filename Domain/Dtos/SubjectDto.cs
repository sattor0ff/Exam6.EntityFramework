namespace Domain.Dtos;

public class SubjectDto
{
    public int SubjectId { get; set; }
    public string Name { get; set; }
    public int Grade { get; set; }
    public string Description { get; set; }
    public int ClassroomId { get; set; }

    public SubjectDto()
    {
        
    }

    public SubjectDto(int subjectid, string name, int grade, string description, int classroomid)
    {
        SubjectId = subjectid;
        Name = name;
        Grade = grade;
        Description = description;  
        ClassroomId = classroomid; 
    }
}